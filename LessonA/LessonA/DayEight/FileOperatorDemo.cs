using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayEight
{
    internal class FileOperatorDemo
    {
        public static void FileWriteAllLLines()
        {
            String fname = @"c:\temp\myFileA.txt";
            string[] lines =
            {
                "chennai is the capital city",
            "Madurai is the temple city",
            "salem is the steel city"
            };
            try
            {
                File.WriteAllLines(fname, lines);
                System.Console.WriteLine("File created");
               
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"Error!!{e.Message}");
            }
            
        }
        public static void FileReadAllText()
        {
            string line = String.Empty;
            String fName = @"c:\temp\myfileA.txt";
            line = File.ReadAllText(fName);
            Console.WriteLine(line);
        }
        public static void FileRename()
        {
            String oldfName = @"c:\temp\myfileA.txt";
            String newfName = @"c:\temp\renamedfileA.txt";
            File.Copy(oldfName, newfName);
            File.Delete(oldfName);
            Console.WriteLine("File Renamed");
        }

        //how to check if a txt exists
        public static void FileDelete()
        {
            String fName = @"c:\temp\myfileA.txt";
            if (File.Exists(fName))
                File.Delete(fName);
            else
                Console.WriteLine("File DELETE FAILED");
        }
        //inside current directory i need the list of all the files in them. we can also give like .docx, .txt
        public static void ListDirectoryContent()
        {
            String currentDir = @"c:\temp\";
            string[] fileNames = Directory.GetFiles(currentDir, "*.*");
            foreach (String name in fileNames)
            {
                Console.WriteLine(name);
            }



            string[] subdirNames = Directory.GetDirectories(currentDir, "*.*");
            foreach (String name in subdirNames)
            {
                Console.WriteLine(name);
            }
        }
        public static void ShowCurrentDirectory()
        {
            String currentworkingdirectory = Directory.GetCurrentDirectory(); //one approach
            Console.WriteLine(currentworkingdirectory);
            currentworkingdirectory = Environment.CurrentDirectory; // second approach . 
            //any one approach is enough. both will give the same result
            Console.WriteLine(currentworkingdirectory);
        }
        public static void CreateDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Create");
            String path = @"c:\temp\" + Console.ReadLine();
            DirectoryInfo dir = Directory.CreateDirectory(path);
            Console.WriteLine("Directory Created " + dir.FullName);
        }



        public static void DeleteDirectory()
        {
            Console.WriteLine("Enter the name of the new Directory to Delete");
            String path = @"c:\temp\" + Console.ReadLine();
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                Console.WriteLine("Directory DELETED");
            }
            else
            {
                Console.WriteLine("Directory Not Available");
            }
        }
        public static void FileWriteAllText()
        {
            String fNameb = @"c:\temp\myfileB.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
      };
            StringBuilder sb = new StringBuilder(100);
            sb.Append(lines[0]);
            sb.Append(Environment.NewLine); // sb.Append("\\n");
            sb.Append(lines[1]);
            sb.Append(Environment.NewLine); // will add a new line in the existing data
            sb.Append(lines[2]);
            sb.Append(Environment.NewLine);
            File.WriteAllText(fNameb, sb.ToString());
            System.Console.WriteLine("File Created");
        }
        //using stream or file which will  be good

        public static void StreamWriterDemo()
        {
            String fName = @"c:\temp\myfileC.txt";
            string[] lines =
            {
          "Chennai is the capital city",
          "Madurai is the Temple city",
          "Salem is the steal city"
      };

            //  StreamWriter
            //  Write one line at a time to a file.
            //  The second String is added as a new Line.

            using (StreamWriter sw = new StreamWriter(fName)) //if obj is created in using block then it is limited within the block
                //stringwriter will be closed. so finally is not required
            {
                foreach (string s in lines)
                {
                    sw.WriteLine(s);
                }
            }
            System.Console.WriteLine("File Created");
        }
    public static void StreamReaderFromFileDemo()
        {
            StringBuilder line = new StringBuilder(250);
            String fName = @"c:\temp\myfileA.txt";
            using (StreamReader sr = new StreamReader(fName))
            {
                line.Append(sr.ReadLine());
                while (!sr.EndOfStream)
                {
                    line.Append(sr.ReadLine());
                    line.Append(Environment.NewLine);
                }
                Console.WriteLine(line.ToString());
            }
            System.Console.WriteLine("Completed");
        }
        //every tym write file will overwrite on them but to append it we can just add the text to the existing file
        static class imageCache
        {
            public static byte[] logo
            {
                get
                {
                    byte[] _logoBytes = null;
                    if(_logoBytes == null)
                    {
                        _logoBytes = File.ReadAllBytes(@"c:\temp\Html_Logo.png");
                    }
                    return _logoBytes;

                }
            }
        }
    }
}
