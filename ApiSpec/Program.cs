using System;

namespace ApiSpec {
    // C:/VulkanSDK/1.1.106.0/Documentation/apispec.html
    class Program {
        const string fileApispec = "apispec.txt";
        static void Main(string[] args) {
            Console.WriteLine("Parsing...");

            //EnumsParser.Testh4();
            //EnumsParser.h4Counts();
            //EnumsParser.DumpEnums();
            //StructsParser.Testh4();
            //StructsParser.h4Counts();
            StructsParser.DumpStructs();

            //Console.ReadKey();
        }
    }

}
