using System;

namespace ApiSpec {
    class Program {
        const string fileApispec = "apispec.txt";
        static void Main(string[] args) {
            Console.WriteLine("Parsing...");
            //XElement root = XElement.Load(fileFlags);
            //var names = new List<string>();
            //TraverseNode(root, names);
            //foreach (var item in names) {
            //    Console.WriteLine(item);
            //}

            EnumsParser.DumpEnums();

            //Console.ReadKey();
        }
    }

}
