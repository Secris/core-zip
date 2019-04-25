using System;
using System.IO;
using System.IO.Compression;

namespace core_zip
{
    class Program
    {
        static void Zipper(string folder, string file)
        {
            ZipFile.CreateFromDirectory(folder, file);
        }
        static void Main(string[] args)
        {
            string inFolder2zip = "";
            string inZipFilename = "";
            string inOverwrite = "";

            if (args.Length == 0)
            {
                Console.WriteLine("What folder would you like to zip? ");
                inFolder2zip = Console.ReadLine();
                Console.WriteLine("What would you like to Call the zip?");
                inZipFilename = Console.ReadLine();

                if (File.Exists(inZipFilename))
                {
                    Console.WriteLine("Would you like to overwrite the existing file? [y/N]");
                    inOverwrite = Console.ReadLine();
                    
                    if (inOverwrite == "y" || inOverwrite == "Y")
                    {
                        File.Delete(inZipFilename);
                        Zipper(inFolder2zip, inZipFilename);
                    }
                    else
                    {
                        Console.WriteLine("Aborting...");
                    }
                }
                else
                {
                    Zipper(inFolder2zip, inZipFilename);
                }
            }
            else
            {
                Console.WriteLine("Args detected");
            }
            
        }
    }
}
