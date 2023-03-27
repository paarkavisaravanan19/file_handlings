using System.IO;

namespace file_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("file handling");
            //FileStream file = new FileStream("C:\\Users\\DELL\\Desktop\\file demo\\filename2.txt", FileMode.OpenOrCreate);
            //text writer
            /*
            using (TextWriter textWriter = File.CreateText("C:\\Users\\DELL\\Desktop\\file demo\\filename2.txt")) 
            {
                char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
                textWriter.WriteLine(charArray,2,3);
               // textWriter.WriteLine("string");
            }   
            */
            /*
            using(TextReader textReader= File.OpenText("C:\\Users\\DELL\\Desktop\\file demo\\filename2.txt"))
            {
                //Console.WriteLine(textReader.ReadLine()); ==> reads the first line
                Console.WriteLine(textReader.ReadToEnd()); //read to end ==> reads the entire file
            }
            */
            /*
            //fileinfo
            //it creates a file and throws error when we don't have access to it
            FileInfo f1 = new("C:\\Users\\DELL\\Desktop\\file demo\\filename3.txt");
            f1.Create();
            */
            DirectoryInfo dr = new("C:\\Users\\DELL\\Desktop\\file demo\\directory");
            
            dr.Create();
            FileInfo f1 = new("C:\\Users\\DELL\\Desktop\\file demo\\directory\\file1.txt");
            f1.Create();

            // dr.Delete(); ==> deletes the directory



            /*
            //stream reader
            StreamReader sr = new StreamReader(file);
            string content = sr.ReadToEnd();
            Console.WriteLine(content);
            sr.Close();
            file.Close();
            */


            /*
             //stream writer
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine("hi hello");
            writer.Close(); 
            file.Close();
            /*
            var path = "C:\\Users\\DELL\\Desktop\\file demo\\filename1.txt";
            string text = "this is text file 1";
            File.WriteAllText(path, text);
            File.AppendAllText(path, "\nhello");
            Console.WriteLine("text written");
            */

        }

       
    }
}