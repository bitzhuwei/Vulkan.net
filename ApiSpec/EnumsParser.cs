﻿using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ApiSpec {
    class EnumsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "{";
        const string rightBrace = "}";

        const string filename = "Enumerations.content.xml";
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

        class EnumComment {
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
            var lstDefinition = new List<EnumDefinetion>();
            TraverseNodesEnumDefinitions(root, lstDefinition);
            var dictComment = new Dictionary<int, EnumComment>(); int index = -1; bool inside = false;
            TraverseNodesEnumComments(root, dictComment, ref index, ref inside);

            using (var sw = new System.IO.StreamWriter("Enums.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    EnumDefinetion definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();
                    EnumComment comment = null;
                    if (dictComment.ContainsKey(i)) { comment = dictComment[i]; }
                    Dictionary<string, string> dict = null;
                    if (comment != null) { dict = comment.Dump(); }
                    foreach (var line in definitionLines) {
                        if (dict != null) {
                            string strComment = ParseComment(line, dict);
                            if (strComment != string.Empty) {
                                strComment = strComment.Replace("\r\n", "\n");
                                strComment = strComment.Replace("\r", "\n");
                                strComment = strComment.Replace("\n", $"{Environment.NewLine}    /// ");
                                sw.WriteLine($"    /// <summary>{strComment}/// </summary>");
                            }
                        }
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Done");
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
        private static string ParseComment(string line, Dictionary<string, string> dict) {
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
        private static void TraverseNodesEnumComments(XElement node, Dictionary<int, EnumComment> dict, ref int index, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "C Specification") {
                    index++; // ready for next EnumComment.
                }
                else if (node.Value == "Description") {
                    inside = true;
                    var comment = new EnumComment();
                    dict.Add(index, comment);
                }
                else if (node.Value == "See Also") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    EnumComment comment = dict[index];
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    comment.lstComment.Add(text);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesEnumComments(item, dict, ref index, ref inside);
            }
        }


        private static void TraverseNodesEnumDefinitions(XElement node, List<EnumDefinetion> list) {
            if (node.Name == "code") {
                XAttribute attrClass = node.Attribute("class");
                if (attrClass != null && attrClass.Value == "language-c++") {
                    string v = node.Value;
                    var item = new EnumDefinetion() { raw = v, };
                    list.Add(item);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesEnumDefinitions(item, list);
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
