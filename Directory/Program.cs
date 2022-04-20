using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryExercise
{
    class DirectoryExercise
    {
        static int Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string sourceDirectory = @"C:\Users\PC\Desktop\source_directory";
            string targetDirectory = @"C:\Users\PC\Desktop\target_directory";

           


            // Trả về danh sách tất cả tệp tin trong thư mục sourceDirectory 
            // Syntax: List<string> lst = Directory.EnumerateFiles().ToList(); 
            List<string> lstFilesName = Directory.EnumerateFiles(sourceDirectory).ToList();

            // Trả về danh sách tất cả thư mục trong thư mục sourceDirectory
            // Syntax: List<string> lst = Directory.EnumerateDirectories().ToList();
            List<string> lstFoldersName = Directory.EnumerateDirectories(sourceDirectory).ToList();




            // Di chuyển một tệp tin từ vị trí hiện tại sang folder mới targetDirectory 
            //Directory.Move(currentFile, Path.Combine(targetDirectory, fileName));
            // Hoặc
            //File.Move(currentFile, Path.Combine(sourceDirectory, fileName));

            

            //Copy một tệp tin từ vị trí hiện tại sang folder mới targetDirectory: 
            //File.Copy(currentFile, Path.Combine(targetDirectory, fileName));


            // Xóa tệp tin 
            //File.Delete(currentFile);
            // Xóa thư mục
            //Directory.Delete(sourceDirectory);


            foreach (string currentFile in lstFilesName)
            {
                Console.WriteLine(currentFile);
                string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                //Directory.Move(currentFile, Path.Combine(targetDirectory, fileName));
                File.Copy(currentFile, Path.Combine(targetDirectory, fileName));
            }

            foreach (string currentFile in lstFoldersName)
            {
                Console.WriteLine(currentFile);
            }

            Console.ReadLine();
            return 1;
        }
    }
}
