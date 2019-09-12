using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ApiSpec {
    class CommandsParser {

        static readonly char[] inLineSeparator = new char[] { ' ', '\t', '\r', '\n', '(', ')' };
        static readonly char[] lineSeparator = new char[] { '\r', '\n' };
        const string leftBrace = "(";
        const string rightBrace = ")";

        const string filename = "Commands.content.xml";
        const string strName = "Name";
        const string strCSpecification = "C Specification";
        const string strParameters = "Parameters";
        const string strDescription = "Description";
        const string strSeeAlso = "See Also";
        const string strDocNotes = "Document Notes";

        class Definition {
            /*typedef void* (VKAPI_PTR *PFN_vkAllocationFunction)(
    void*                                       pUserData,
    size_t                                      size,
    size_t                                      alignment,
    VkSystemAllocationScope                     allocationScope);
             */
            public string raw;

            public string[] Dump() {
                string[] lines = this.raw.Split(lineSeparator, StringSplitOptions.RemoveEmptyEntries);
                if (lines == null || lines.Length < 2) { return lines; }

                {
                    //string[] parts = lines[0].Split(inLineSeparator, StringSplitOptions.RemoveEmptyEntries);
                    //lines[0] = $"public {parts[0]} {parts[3].Substring(1)} {leftBrace}";
                    lines[0] = $"public static extern {lines[0]}";
                }

                return lines;
            }
        }

        class ItemComment {
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

        class ItemDescription {
            public List<string> lstComment = new List<string>();
        }

        public static void DumpCommands() {
            XElement root = XElement.Load(filename);
            var lstDefinition = new List<Definition>(); bool inside = false;
            TraverseDefinitions(root, lstDefinition, ref inside);
            var lstItemComment = new List<ItemComment>(); inside = false;
            TraverseItemComments(root, lstItemComment, ref inside);
            var lstComment = new List<string>(); inside = false;
            TraverseComments(root, lstComment, ref inside);
            //var lstItemDescription = new List<ItemDescription>(); inside = false;
            //TraverseDescriptions(root, lstItemDescription, ref inside);

            using (var sw = new System.IO.StreamWriter("Commands.gen.cs")) {
                sw.WriteLine("const string VulkanLibrary = \"vulkan-1\";");
                for (int i = 0; i < lstDefinition.Count; i++) {
                    Definition definition = lstDefinition[i];
                    //sw.WriteLine(definition.raw);
                    string[] definitionLines = definition.Dump();
                    ItemComment itemComment = lstItemComment[i];
                    Dictionary<string, string> item2Comment = itemComment.Dump();
                    //ItemDescription itemDescription = lstItemDescription[i];

                    sw.WriteLine($"// Command: {i}");
                    string comment = lstComment[i];
                    sw.WriteLine($"/// <summary>{comment}");
                    // description is too long.
                    //foreach (var item in itemDescription.lstComment) {
                    //    string s = item.Replace("\r", "");
                    //    s = s.Replace("\n", "");
                    //    string c = RemoveBraces(s);
                    //    sw.WriteLine($"/// <para>{c}</para>");
                    //}
                    sw.WriteLine($"/// </summary>");
                    // /// <param name="device"></param>
                    for (int j = 1; j < definitionLines.Length; j++) {
                        string line = definitionLines[j];
                        if (item2Comment != null) {
                            string key;
                            string strComment = ParseItemComment(line, item2Comment, out key);
                            if (strComment != string.Empty) {
                                strComment = strComment.Replace("\r\n", "\n");
                                strComment = strComment.Replace("\r", "\n");
                                strComment = strComment.Replace("\n", $"{Environment.NewLine}    /// ");
                                strComment = RemoveBraces(strComment);
                                sw.WriteLine(string.Format("/// <param name=\"{0}\">{1}</param>", key, strComment));
                            }
                        }
                    }
                    {
                        sw.WriteLine("[DllImport(VulkanLibrary, CallingConvention = CallingConvention.Winapi)]");
                        string line = definitionLines[0];
                        line = line.Trim();
                        var l = line.Replace("const char* ", "IntPtr ");
                        l = l.Replace("const*", "/*-const-*/ *");
                        l = l.Replace("const ", "/*-const-*/ ");
                        l = l.Replace(" const", " /*-const-*/");
                        l = l.Replace("size_t ", "Int32 ");
                        l = l.Replace("size_t*", "Int32*");
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
                        sw.WriteLine(l); // public static extern VkResult vkAcquireFullScreenExclusiveModeEXT( ...
                    }
                    for (int j = 1; j < definitionLines.Length; j++) {
                        string line = definitionLines[j];
                        line = line.Trim();
                        var l = line.Replace("const char* ", "IntPtr ");
                        l = l.Replace("const*", "/*-const-*/ *");
                        l = l.Replace("const ", "/*-const-*/ ");
                        l = l.Replace(" const", " /*-const-*/");
                        l = l.Replace("size_t ", "Int32 ");
                        l = l.Replace("size_t*", "Int32*");
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

        /*<h4 id="_description">Description</h4>
        <div class="sidebarblock">
        <div class="content">
        <div class="title">Valid Usage</div>
        <div class="ulist">
        <ul>
        <li>
        <p><a id="VUID-vkAcquireFullScreenExclusiveModeEXT-swapchain-02674"></a>
        <code>swapchain</code> <strong class="purple">must</strong> not be in the retired state</p>*/
        private static void TraverseDescriptions(XElement node, List<ItemDescription> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Description") {
                    inside = true;
                    var comment = new ItemDescription();
                    list.Add(comment);
                }
                else if (node.Value == "See Also") {
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

        /*<h4 id="_name">Name</h4>
        <div class="paragraph">
        <p>vkAcquireFullScreenExclusiveModeEXT - Acquire full-screen exclusive mode for a swapchain</p>
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
        private static string ParseItemComment(string line, Dictionary<string, string> dict, out string key) {
            string result = string.Empty; key = "???";
            string[] parts = line.Split(itemSeparator, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 0) {
                key = parts[parts.Length - 1];
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
        private static void TraverseItemComments(XElement node, List<ItemComment> list, ref bool inside) {
            if (node.Name == "h4") {
                if (node.Value == "Parameters") {
                    inside = true;
                    var comment = new ItemComment();
                    list.Add(comment);
                }
                else if (node.Value == "Description") {
                    inside = false;
                }
            }
            else if (node.Name == "p") {
                if (inside) {
                    ItemComment comment = list[list.Count - 1];
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


        private static void TraverseDefinitions(XElement node, List<Definition> list, ref bool inside) {
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
                        var item = new Definition() { raw = v, };
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

            // all are 326. Great!
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
