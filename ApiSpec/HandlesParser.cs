using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class HandlesParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', '(', ')' };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "(";
        const string rightBrace = ")";

        const string filename = "Handles.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class Definition {
            /*<h3 id="_vkaccelerationstructurenv3">VkAccelerationStructureNV(3)</h3>
             */
            public string raw;

            // public struct raw { UInt64 handle; }
            public string Dump() {
                var builder = new StringBuilder();
                builder.AppendLine(string.Format(@"public struct {0} {1}", raw, "{"));
                builder.AppendLine("    public UInt64 handle;");
                builder.AppendLine(string.Format("{0}", "}"));

                return builder.ToString();
            }
        }

        class ItemDescription {
            public List<string> lstComment = new List<string>();
        }

        public static void DumpHandles() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<Definition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);
            var lstComment = new List<string>(); inside = false;
            TraverseComments(root, lstComment, ref inside);
            var lstItemDescription = new List<ItemDescription>(); inside = false;
            TraverseDescriptions(root, lstItemDescription, ref inside);

            using (var sw = new System.IO.StreamWriter("Handles.gen.cs")) {
                for (int i = 0; i < lstDefinition.Count; i++) {
                    sw.WriteLine($"// Object Handles: {i}");

                    string comment = lstComment[i];
                    sw.WriteLine($"/// <summary>{comment}");
                    //// description is too long.
                    ItemDescription itemDescription = lstItemDescription[i];
                    foreach (var item in itemDescription.lstComment) {
                        string s = item.Replace("\r", "");
                        s = s.Replace("\n", "");
                        string c = RemoveBraces(s);
                        sw.WriteLine($"/// <para>{c}</para>");
                    }
                    sw.WriteLine($"/// </summary>");

                    Definition definition = lstDefinition[i];
                    sw.WriteLine(definition.Dump());
                }
            }
            Console.WriteLine("Done");
        }

        static readonly char[] braceSeparator = new char[] { '<', '>', };
        // remove <> </>
        private static string RemoveBraces(string strComment) {
            var leftBraces = new List<int>();
            var rightBraces = new List<int>();
            for (int i = 0; i < strComment.Length; i++) {
                char c = strComment[i];
                if (c == '<') { leftBraces.Add(i); }
                else if (c == '>') { rightBraces.Add(i); }
            }

            if (leftBraces.Count != rightBraces.Count) { return strComment; }

            var builder = new StringBuilder();
            int current = 0; leftBraces.Add(strComment.Length); rightBraces.Insert(0, -1);
            for (int i = 0; i < leftBraces.Count; i++) {
                current = rightBraces[i] + 1;
                int left = leftBraces[i];
                string segment = strComment.Substring(current, left - current);
                if (!string.IsNullOrWhiteSpace(segment)) {
                    builder.Append(segment);
                }
                else {
                    builder.Append(" ");
                }
            }

            return builder.ToString();
        }

        /*<h4 id="_c_specification_327">C Specification</h4>
<div class="paragraph">
<p>Acceleration structures are an opaque structure that is built by the
implementation to more efficiently perform spatial queries on the provided
geometric data.
For this extension, an acceleration structure is either a top-level
acceleration structure containing a set of bottom-level acceleration
structures or a bottom-level acceleration structure containing either a set
of axis-aligned bounding boxes for custom geometry or a set of triangles.</p>*/
        private static void TraverseDescriptions(XElement node, List<ItemDescription> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "C Specification") {
                    inside = true;
                    var comment = new ItemDescription();
                    list.Add(comment);
                }
                else if (node.Value == "Description") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    ItemDescription comment = list[list.Count - 1];
                    string text = node.ToString();
                    text = text.Substring("<p>".Length, text.Length - "<p></p>".Length);
                    text = text.Trim();
                    comment.lstComment.Add(text);
                }
            }

            foreach (XElement item in node.Elements()) {
                TraverseDescriptions(item, list, ref inside);
            }
        }

        /*<h4 id="_name_327">Name</h4>
<div class="paragraph">
<p>VkAccelerationStructureNV - Opaque handle to an acceleration structure object</p>
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

        private static void TraverseDefinitions(XElement node, List<Definition> list, ref bool inside) {
            if (node.Name == "h3") {
                string v = node.Value;
                var item = new Definition() { raw = v.Split('(')[0], };
                list.Add(item);
            }

            foreach (XElement item in node.Elements()) {
                TraverseDefinitions(item, list, ref inside);
            }
        }

        public static void h4Counts() {
            XElement root = XElement.Load(filename);
            var info = new h4Count();
            TraverseNodesCounts(root, info);

            // all are 37. Great!
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
