using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ApiSpec {
    class EnumsParser {

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

            static readonly char[] lineSeparator = new char[] { '\r', '\n' };
            static readonly char[] inLineSeparator = new char[] { ' ', '\t' };
            const string leftBrace = "{";
            const string rightBrace = "}";
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

        public static void DumpEnums() {
            XElement root = XElement.Load(filename);
            var list = new List<EnumDefinetion>();
            TraverseNodesEnums(root, list);

            using (var sw = new System.IO.StreamWriter("Enums.gen.cs")) {
                foreach (var item in list) {
                    //sw.WriteLine(item.raw);
                    string[] dumped = item.Dump();
                    foreach (var line in dumped) {
                        sw.WriteLine(line);
                    }
                }
            }
            Console.WriteLine("Done");
        }

        private static void TraverseNodesEnums(XElement node, List<EnumDefinetion> list) {
            if (node.Name == "code") {
                XAttribute attrClass = node.Attribute("class");
                if (attrClass != null && attrClass.Value == "language-c++") {
                    string v = node.Value;
                    var item = new EnumDefinetion() { raw = v, };
                    list.Add(item);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseNodesEnums(item, list);
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
                } else if (v == strCSpecification) {
                    info.cSpecifications++;
                } else if (v == strDescription) {
                    info.descriptions++;
                } else if (v == strSeeAlso) {
                    info.seeAlsos++;
                } else if (v == strDocNotes) {
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
