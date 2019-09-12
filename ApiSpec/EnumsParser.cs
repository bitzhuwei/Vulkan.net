using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ApiSpec {
    class EnumsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "{";
        const string rightBrace = "}";

        const string filename = "Enums.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class EnumDefinetion {
            /*typedef enum VkAccelerationStructureMemoryRequirementsTypeNV {
    VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV = 0,
    VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV = 1,
    VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV = 2,
    VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_MAX_ENUM_NV = 0x7FFFFFFF
} VkAccelerationStructureMemoryRequirementsTypeNV;
             */
            public string raw;

            public string[] Dump() {
                string[] lines = this.raw.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
                if (lines == null || lines.Length < 2) { return lines; }

                {
                    string[] parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    lines[0] = $"public enum {parts[2]} {leftBrace}";
                }
                {
                    int last = lines.Length - 1;
                    lines[last] = $"{rightBrace}";
                }

                return lines;
            }
        }

        class EnumItemComment {
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

        public static void DumpEnums() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<EnumDefinetion>(); bool inside = false;
            TraverseNodesEnumDefinitions(root, lstDefinition, ref inside);
            var listEnumItemComment = new List<EnumItemComment>(); inside = false;
            TraverseNodesEnumItemComments(root, listEnumItemComment, ref inside);
            var lstEnumComment = new List<string>(); inside = false;
            TraverseNodesEnumComments(root, lstEnumComment, ref inside);

            using (var sw = new System.IO.StreamWriter("Enums.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    EnumDefinetion definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();
                    EnumItemComment itemComment = listEnumItemComment[i];
                    Dictionary<string, string> item2Comment = itemComment.Dump();

                    sw.WriteLine($"// Enum: {i}");
                    string enumComment = lstEnumComment[i];
                    sw.WriteLine($"/// <summary>{enumComment}</summary>");
                    {
                        string line = definitionLines[0];
                        if (line.Contains("FlagBits")) { sw.WriteLine("[Flags]"); }
                        sw.WriteLine(line);
                    }
                    for (int j = 1; j < definitionLines.Length - 1; j++) {
                        string line = definitionLines[j];
                        if (item2Comment != null) {
                            string strComment = ParseItemComment(line, item2Comment);
                            if (strComment != string.Empty) {
                                strComment = strComment.Replace("\r\n", "\n");
                                strComment = strComment.Replace("\r", "\n");
                                strComment = strComment.Replace("\n", $"{Environment.NewLine}    /// ");
                                sw.WriteLine($"    /// <summary>{strComment}</summary>");
                            }
                        }
                        sw.WriteLine(line);
                    }
                    {
                        string line = definitionLines[definitionLines.Length - 1];
                        sw.WriteLine(line); // }
                    }
                }
            }
            Console.WriteLine("Done");
        }

        /*<h4 id="_name_800">Name</h4>
<div class="paragraph">
<p>VkAccessFlagBits - Bitmask specifying memory access types that will participate in a memory dependency</p>
</div>*/
        private static void TraverseNodesEnumComments(XElement node, List<string> list, ref bool inside) {
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
                TraverseNodesEnumComments(item, list, ref inside);
            }
        }

        /* line:    VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV = 0,
         *     
        comment: <code>VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_NV</code> is a top-level
        acceleration structure containing instance data referring to
bottom-level level acceleration structures.
<code>VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_NV</code> is a bottom-level
acceleration structure containing the AABBs or geometry to be
intersected.
    */
        static readonly char[] equalSeparator = new char[] { '=', ' ', '\t', '\r', '\n', };
        private static string ParseItemComment(string line, Dictionary<string, string> dict) {
            string result = string.Empty;
            string[] parts = line.Split(equalSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2) {
                string key = parts[0];
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
        private static void TraverseNodesEnumItemComments(XElement node, List<EnumItemComment> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Description") {
                    inside = true;
                    var comment = new EnumItemComment();
                    list.Add(comment);
                }
                else if (node.Value == "See Also") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    EnumItemComment comment = list[list.Count - 1];
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    comment.lstComment.Add(text);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesEnumItemComments(item, list, ref inside);
            }
        }


        private static void TraverseNodesEnumDefinitions(XElement node, List<EnumDefinetion> list, ref bool inside) {
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
                        var item = new EnumDefinetion() { raw = v, };
                        list.Add(item);
                        inside = false;
                    }
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesEnumDefinitions(item, list, ref inside);
            }
        }

        public static void h4Counts() {
            XElement root = XElement.Load(filename);
            var info = new h4Count();
            TraverseNodesCounts(root, info);

            // all are 143. Great!
            Console.WriteLine("Name: {0}", info.names);
            Console.WriteLine("C Specification: {0}", info.cSpecifications);
            Console.WriteLine("Description: {0}", info.descriptions);
            Console.WriteLine("See Also: {0}", info.seeAlsos);
            Console.WriteLine("Document Notes: {0}", info.docNotes);

        }
        class h4Count {
            public int names = 0, cSpecifications = 0, descriptions = 0, seeAlsos = 0, docNotes = 0;
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
