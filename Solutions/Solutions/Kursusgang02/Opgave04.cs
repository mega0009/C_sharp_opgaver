using System;
using System.IO;

namespace Solutions.Kursusgang02
{
    class Opgave05
    {
        public static void Run() // svarer til main
        {
            // jeg har googlet DirectoryInfo og FileInfo - første hit på begge:
            // https://msdn.microsoft.com/en-us/library/system.io.fileinfo(v=vs.110).aspx
            // https://msdn.microsoft.com/en-us/library/system.io.directoryinfo(v=vs.110).aspx

            DirectoryInfo root = new DirectoryInfo(@"c:\");

            Console.WriteLine("Filer:");
            foreach (FileInfo file in root.GetFiles())
            {
                Console.WriteLine($"{file.Name} fylder {file.Length} bytes");
            }
            Console.WriteLine("Mapper");
            foreach (DirectoryInfo directory in root.GetDirectories())
            {
                try // når jeg kører det, skulle jeg gerne finde ud af, at jeg får en exception! 
                    // - den skal selvfølgelig håndteres
                {
                    int antalFilerOgMapper = directory.GetDirectories().Length + directory.GetFiles().Length;
                    Console.WriteLine($"Mappe: {directory.Name} Antal filer: {antalFilerOgMapper}");
                }
                catch (UnauthorizedAccessException e) // min håndtering er bare, at skrive den ud...
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
