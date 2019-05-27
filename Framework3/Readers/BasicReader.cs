using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Framework3
{
    public class BasicReader
    {
        // took from here http://www.csharp-examples.net/read-text-file/

        public string ReadFileIntoString()
        {
            //Read Text File into String
            string text = File.ReadAllText(@"C:\C-sharpAsFuck\Framework3\Framework3\Framework3\ReaderData.csv", Encoding.UTF8);
            return text;
        }



        public string ReadfileIntoStringWithStreamReader()
        {
            // Read Text File into String (with StreamReader), which will close file later.
            string text;
            var fileStream = new FileStream(@"C:\C-sharpAsFuck\Framework3\Framework3\Framework3\ReaderData.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                text = streamReader.ReadToEnd();
            }

            return text;
        }

        public string[] ReadFileIntoStringArray()
        {
            string[] lines = File.ReadAllLines(@"C:\C-sharpAsFuck\Framework3\Framework3\Framework3\ReaderData.csv", Encoding.UTF8);

            return lines;
        }

        public string[] ReadFileIntoStringArrayWithStreamReader()
        {
            string[] lines;
            var list = new List<string>();
            var fileStream = new FileStream(@"C:\C-sharpAsFuck\Framework3\Framework3\Framework3\ReaderData.csv", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            lines = list.ToArray();

            return lines;
        }

        public void ReadFileLineByLine()
        {
            // To reduce memory usage for large text files, you can process lines immediately instead
            // of adding it to the list as in the previous example. To do that use 
            // File.ReadLines. This method internally creates Enumerator. 
            // Every time foreach asks for a next value, it calls StreamReader.Re­adLine 
            // under the hood.

            foreach (string line in File.ReadLines(@"c:\file.txt", Encoding.UTF8))
            {
                // process the line
            }

        }

        public void ReadFileLineByLineWithStreamReader()
        {
            var fileStream = new FileStream(@"c:\file.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // process the line
                }
            }

        }
    }
}
