using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class StructsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "{";
        const string rightBrace = "}";

        const string filename = "Structures.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strMembers = "Members";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class StructDefinition {
            /*typedef struct VkAccelerationStructureCreateInfoNV {
    VkStructureType                  sType;
    const void*                      pNext;
    VkDeviceSize                     compactedSize;
    VkAccelerationStructureInfoNV    info;
} VkAccelerationStructureCreateInfoNV;
             */
            public string raw;

            public string[] Dump() {
                string[] lines = this.raw.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
                if (lines == null || lines.Length < 2) { return lines; }

                {
                    string[] parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts[1] == "union") {
                        lines[0] = $"/*union*/[StructLayout(LayoutKind.Explicit)] public struct {parts[2]} {leftBrace}";
                    }
                    else {
                        lines[0] = $"public struct {parts[2]} {leftBrace}";
                    }
                }
                {
                    int last = lines.Length - 1;
                    lines[last] = $"{rightBrace}";
                }

                return lines;
            }
        }

        class StructItemComment {
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

        public static void DumpStructs() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<StructDefinition>(); bool inside = false;
            TraverseNodesStructDefinitions(root, lstDefinition, ref inside);
            var listStructItemComment = new List<StructItemComment>(); inside = false;
            TraverseNodesStructItemComments(root, listStructItemComment, ref inside);
            var lstStructComment = new List<string>(); inside = false;
            TraverseNodesStructComments(root, lstStructComment, ref inside);

            using (var sw = new System.IO.StreamWriter("Structs.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    StructDefinition definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();
                    StructItemComment itemComment = listStructItemComment[i];
                    Dictionary<string, string> item2Comment = itemComment.Dump();

                    sw.WriteLine($"// Struct: {i}");
                    string enumComment = lstStructComment[i];
                    sw.WriteLine($"/// <summary>{enumComment}</summary>");
                    bool isUnion = false;
                    {
                        string line = definitionLines[0];
                        if (line.StartsWith("/*union*/")) {
                            isUnion = true;
                        }
                        sw.WriteLine(line); // public struct XXX {
                    }
                    for (int j = 1; j < definitionLines.Length - 1; j++) {
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
                            var l = line.Replace("const char* ", " IntPtr ");
                            l = l.Replace("const ", " /* const */ ");
                            l = l.Replace("uint8_t* ", " byte* ");
                            l = l.Replace("uint8_t ", " byte ");
                            l = l.Replace("uint16_t* ", " UInt16* ");
                            l = l.Replace("uint16_t ", " UInt16 ");
                            l = l.Replace("uint32_t* ", " UInt32* ");
                            l = l.Replace("uint32_t ", " UInt32 ");
                            l = l.Replace("uint64_t* ", " UInt64* ");
                            l = l.Replace("uint64_t ", " UInt64 ");
                            l = l.Replace("int32_t* ", " Int32* ");
                            l = l.Replace("int32_t ", " Int32 ");
                            l = l.Replace("int64_t* ", " Int64* ");
                            l = l.Replace("int64_t ", " Int64 ");
                            l = l.Replace("struct ", " /* struct */ ");
                            l = l.Replace(" object;", " _object;");
                            if (l.Contains("[")) { l = "fixed " + l; }
                            l = "public " + l;
                            if (isUnion) { l = "[FieldOffset(0)] " + l; }
                            l = "    " + l;
                            sw.WriteLine(l);
                        }
                    }
                    {
                        string line = definitionLines[definitionLines.Length - 1];
                        sw.WriteLine(line); // }
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

        /*<h4 id="_name_364">Name</h4>
<div class="paragraph">
<p>VkAccelerationStructureCreateInfoNV - Structure specifying the parameters of a newly created acceleration structure object</p>
</div>*/
        private static void TraverseNodesStructComments(XElement node, List<string> list, ref bool inside) {
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
                TraverseNodesStructComments(item, list, ref inside);
            }
        }

        /* line:    VkStructureType                  sType;
         * line:    const void*                      pNext;
         * comment: <code>sType</code> is the type of this structure.
        */
        static readonly char[] itemSeparator = new char[] { ' ', ';', '\t', '\r', '\n', };
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
        private static void TraverseNodesStructItemComments(XElement node, List<StructItemComment> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Members") {
                    inside = true;
                    var comment = new StructItemComment();
                    list.Add(comment);
                }
                else if (node.Value == "Description") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    StructItemComment comment = list[list.Count - 1];
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    comment.lstComment.Add(text);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesStructItemComments(item, list, ref inside);
            }
        }


        private static void TraverseNodesStructDefinitions(XElement node, List<StructDefinition> list, ref bool inside) {
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
                        var item = new StructDefinition() { raw = v, };
                        list.Add(item);
                        inside = false;
                    }
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesStructDefinitions(item, list, ref inside);
            }
        }

        public static void h4Counts() {
            XElement root = XElement.Load(filename);
            var info = new h4Count();
            TraverseNodesCounts(root, info);

            // all are 434. Great!
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
                else if (v == strMembers) {
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
        /// strMembers
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
