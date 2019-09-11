using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ApiSpec {
    class FlagsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', '(', ')' };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "(";
        const string rightBrace = ")";

        const string filename = "Flags.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class Definition {
            /*<h4 id="_name_951">Name</h4>
<div class="paragraph">
<p>VkCommandPoolResetFlags - Bitmask of VkCommandPoolResetFlagBits</p>
</div> 
             */
            public string raw;

            static readonly char[] separator = new char[] { ' ', '\t', '\r', '\n', '-' };
            public string[] Dump() {
                var result = new string[2];
                string[] parts = this.raw.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 4 && parts[1] == "Bitmask" && parts[2] == "of") {
                    result[0] = parts[0];
                    result[1] = parts[3];
                }
                else {
                    result[0] = this.raw;
                    result[1] = string.Empty;
                }

                return result;
            }
        }

        public static void DumpFlags() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<Definition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);

            using (var sw = new System.IO.StreamWriter("Flags.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    Definition definition = lstDefinition[i];
                    string[] parts = definition.Dump();
                    if (parts[1] != string.Empty) {
                        sw.WriteLine($"using {parts[0]} = ApiSpec.Generated.{parts[1]};");
                    }
                    else {
                        sw.WriteLine($"// {parts[0]}");
                    }
                }
            }
            Console.WriteLine("Done");
        }

        private static void TraverseDefinitions(XElement node, List<Definition> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Name") {
                    inside = true;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    string v = node.Value;
                    var item = new Definition() { raw = v, };
                    list.Add(item);
                    inside = false;
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

            // all are 99. Great!
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
