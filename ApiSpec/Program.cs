using System;

namespace ApiSpec {
    // C:/VulkanSDK/1.1.106.0/Documentation/apispec.html
    class Program {
        const string fileApispec = "apispec.txt";
        static void Main(string[] args) {
            Console.WriteLine("Parsing...");

            //EnumsParser.Testh4();
            //EnumsParser.h4Counts();
            EnumsParser.DumpEnums();

            //HandlesParser.Testh4();
            //HandlesParser.h4Counts();
            HandlesParser.DumpHandles();

            //FlagsParser.Testh4();
            //FlagsParser.h4Counts();
            FlagsParser.DumpFlags();

            //PFNsParser.Testh4();
            //PFNsParser.h4Counts();
            PFNsParser.DumpPFNs();

            //StructsParser.Testh4();
            //StructsParser.h4Counts();
            StructsParser.DumpStructs();

            //CommandsParser.Testh4();
            //CommandsParser.h4Counts();
            CommandsParser.DumpCommands();

            Console.ReadKey();
        }
    }


}
