using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class PFNsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', '(', ')' };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "(";
        const string rightBrace = ")";

        const string filename = "PFNs.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strParameters = "Parameters";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class PFNDefinition {
            /*typedef void* (VKAPI_PTR *PFN_vkAllocationFunction)(
    void*                                       pUserData,
    size_t                                      size,
    size_t                                      alignment,
    VkSystemAllocationScope                     allocationScope);
             */
            public string raw;

            public string[] Dump() {
                string[] lines = this.raw.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
                if (lines == null || lines.Length < 1) { return lines; }

                {
                    string[] parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    lines[0] = $"public unsafe delegate {parts[1]} {parts[3].Substring(1)} {leftBrace}";
                }

                return lines;
            }
        }

        class PFNItemComment {
            public List<string> lstComment = new List<string>();

            public Dictionary<string, string> Dump() {
                Dictionary<string, string> dict = new Dictionary<string, string>();
                foreach (var item in lstComment) {
                    int left = item.IndexOf("<code>");
                    int right = item.IndexOf("</code>");
                    if (left != -1 && right != -1) {
                        string key = item.Substring(left + "<code>".Length, right - (left + "<code>".Length));
                        if (!dict.ContainsKey(key)) {
                            dict.Add(key, item);
                        }
                    }
                }

                return dict;
            }
        }

        public static void DumpPFNs() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<PFNDefinition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);
            var lstItemComment = new List<PFNItemComment>(); inside = false;
            TraverseItemComments(root, lstItemComment, ref inside);
            var lstComment = new List<string>(); inside = false;
            TraverseComments(root, lstComment, ref inside);

            using (var sw = new System.IO.StreamWriter("PFNs.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    PFNDefinition definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();
                    PFNItemComment itemComment = lstItemComment[i];
                    Dictionary<string, string> item2Comment = itemComment.Dump();

                    sw.WriteLine($"// PFN: {i}");
                    string comment = lstComment[i];
                    sw.WriteLine($"/// <summary>{comment}</summary>");
                    {
                        string line = definitionLines[0];
                        sw.WriteLine(line); // public unsafe delegate ...
                    }
                    for (int j = 1; j < definitionLines.Length; j++) {
                        string line = definitionLines[j];
                        if (item2Comment != null) {
                            string strComment = ParseItemComment(line, item2Comment);
                            if (strComment != string.Empty) {
                                strComment = strComment.Replace("\r\n", "\n");
                                strComment = strComment.Replace("\r", "\n");
                                strComment = strComment.Replace("\n", $"{Environment.NewLine}    /// ");
                                strComment = RemoveBraces(strComment);
                                sw.WriteLine($"    /// <summary>{strComment}</summary>");
                            }
                        }
                        {
                            line = line.Trim();
                            var l = line.Replace("const char* ", "IntPtr ");
                            l = l.Replace("const*", "/*-const-*/ *");
                            l = l.Replace("const ", "/*-const-*/ ");
                            l = l.Replace(" const", " /*-const-*/");
                            l = l.Replace("size_t ", "Int32 ");
                            l = l.Replace("uint8_t* ", "byte* ");
                            l = l.Replace("uint8_t ", " byte ");
                            l = l.Replace("uint16_t* ", "UInt16* ");
                            l = l.Replace("uint16_t ", "UInt16 ");
                            l = l.Replace("uint32_t* ", "UInt32* ");
                            l = l.Replace("uint32_t ", "UInt32 ");
                            l = l.Replace("uint64_t* ", "UInt64* ");
                            l = l.Replace("uint64_t ", "UInt64 ");
                            l = l.Replace("int32_t* ", "Int32* ");
                            l = l.Replace("int32_t ", "Int32 ");
                            l = l.Replace("int64_t* ", "Int64* ");
                            l = l.Replace("int64_t ", "Int64 ");
                            l = l.Replace("struct ", "/* struct */ ");
                            l = l.Replace(" object", " _object");
                            l = l.Replace(" event", " _event");
                            l = "    " + l;
                            sw.WriteLine(l);
                        }
                    }
                    if (definitionLines.Length < 2) {
                        sw.WriteLine(");");
                    }
                }
            }
            Console.WriteLine("Done");
        }

        static readonly char[] braceSeparator = new char[] { '<', '>', };
        // remove <> </>
        private static string RemoveBraces(string strComment) {
            var builder = new StringBuilder();
            bool inside = false;
            foreach (var item in strComment) {
                if (item == '<') { inside = true; }
                else if (item == '>') { inside = false; }
                else {
                    if (!inside) {
                        builder.Append(item);
                    }
                }
            }

            return builder.ToString();
        }

        /*<h4 id="_name_1040">Name</h4>
<div class="paragraph">
<p>PFN_vkAllocationFunction - Application-defined memory allocation function</p>
</div>*/
        private static void TraverseComments(XElement node, List<string> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Name") {
                    inside = true;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    list.Add(text);
                    inside = false;
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseComments(item, list, ref inside);
            }
        }

        /* line:    void*                                       pUserData,
         * line:    VkSystemAllocationScope                     allocationScope);
         * comment: <code>pUserData</code> is the value specified for
<a href="#VkAllocationCallbacks">VkAllocationCallbacks</a>::<code>pUserData</code> in the allocator specified
by the application.
        */
        static readonly char[] itemSeparator = new char[] { ' ', ',', ';', '\t', '\r', '\n', ')', };
        private static string ParseItemComment(string line, Dictionary<string, string> dict) {
            string result = string.Empty;
            string[] parts = line.Split(itemSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0) {
                string key = parts[parts.Length - 1];
                if (dict.ContainsKey(key)) {
                    result = dict[key];
                }
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        /// <param name="list"></param>
        /// <param name="inside"></param>
        private static void TraverseItemComments(XElement node, List<PFNItemComment> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Parameters") {
                    inside = true;
                    var comment = new PFNItemComment();
                    list.Add(comment);
                }
                else if (node.Value == "Description") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    PFNItemComment comment = list[list.Count - 1];
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    comment.lstComment.Add(text);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseItemComments(item, list, ref inside);
            }
        }


        private static void TraverseDefinitions(XElement node, List<PFNDefinition> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "C Specification") {
                    inside = true;
                }
            }
            else if (node.Name == "code") {
                if (inside) {
                    XAttribute attrClass = node.Attribute("class");
                    if (attrClass != null && attrClass.Value == "language-c++") {
                        string v = node.Value;
                        var item = new PFNDefinition() { raw = v, };
                        list.Add(item);
                        inside = false;
                    }
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseDefinitions(item, list, ref inside);
            }
        }

        public static void h4Counts() {
            XElement root = XElement.Load(filename);
            var info = new h4Count();
            TraverseNodesCounts(root, info);

            // all are 8. Great!
            Console.WriteLine("Name: {0}", info.names);
            Console.WriteLine("C Specification: {0}", info.cSpecifications);
            Console.WriteLine("Members: {0}", info.members);
            Console.WriteLine("Description: {0}", info.descriptions);
            Console.WriteLine("See Also: {0}", info.seeAlsos);
            Console.WriteLine("Document Notes: {0}", info.docNotes);

        }
        class h4Count {
            public int names = 0, cSpecifications = 0, members = 0, descriptions = 0, seeAlsos = 0, docNotes = 0;
        }

        private static void TraverseNodesCounts(XElement node, h4Count info) {
            if (node.Name == "h4") {
                string v = node.Value;
                if (v == strName) {
                    info.names++;
                }
                else if (v == strCSpecification) {
                    info.cSpecifications++;
                }
                else if (v == strParameters) {
                    info.members++;
                }
                else if (v == strDescription) {
                    info.descriptions++;
                }
                else if (v == strSeeAlso) {
                    info.seeAlsos++;
                }
                else if (v == strDocNotes) {
                    info.docNotes++;
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesCounts(item, info);
            }
        }

        public static void Testh4() {
            XElement root = XElement.Load(filename);
            var names = new List<string>();
            TraverseNodeh4(root, names);
            foreach (var item in names) {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// gathered h4 contents are:
        /// Name
        /// C Specification
        /// Parameters
        /// Description
        /// See Also
        /// Document Notes
        /// </summary>
        /// <param name="node"></param>
        /// <param name="names"></param>
        private static void TraverseNodeh4(XElement node, List<string> names) {
            if (node.Name == "h4") {
                string v = node.Value;
                if (!names.Contains(v)) { names.Add(v); }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodeh4(item, names);
            }
        }

    }
}
