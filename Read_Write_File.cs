using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string text = System.IO.File.ReadAllText(@"C:\Users\THUVIEN\Desktop\file_to_read.txt", Encoding.UTF8);

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // Example #2
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\THUVIEN\Desktop\file_to_read_2.txt", Encoding.UTF8);

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

    
            ExampleAsync();
        }

        public static async Task ExampleAsync()
        {
            // Write file using StreamWriter  
            /*
                bytes[] 
                stream --> bytes[]

                string --> bytes[] neu khong dung streamwriter
             */
            using (StreamWriter writer = new StreamWriter(@"C:\Users\THUVIEN\Desktop\file_to_write.txt"))
            {
                writer.WriteLine("Monica Rathbun");
                writer.WriteLine("Vidya Agarwal");
                writer.WriteLine("Mahesh Chand");
                writer.WriteLine("Vijay Anand");
                writer.WriteLine("Jignesh Trivedi");
            }
        }
    }
}
