using System;
using System.IO.Compression;

namespace core_zip
{
    class Program
    {
        static void Zipper(string folder, string file, bool overwrite)
        {
            ZipFile.CreateFromDirectory(@".\" + folder, @".\" + file);
        }
        static void Main(string[] args)
        {
            string folder2zip = "";
            string zipFilename = "";
            bool overwrite = false;

            if (args.Length == 0)
            {
                Console.WriteLine("No args detected");
                Console.WriteLine("What folder would you like to zip? ");
                folder2zip = Console.ReadLine();
                Console.WriteLine("What would you like to Call the zip?");
                zipFilename = Console.ReadLine();

                Zipper(folder2zip, zipFilename, overwrite);
            }
            else
            {
                Console.WriteLine("Args detected");
            }
            
        }
    }
}
