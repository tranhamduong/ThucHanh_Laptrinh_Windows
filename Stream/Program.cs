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
            string line = "";


            // Khởi tạo StreamReader để đọc dữ liệu từ tệp tin input.txt
            StreamReader reader = new StreamReader(@"C:\Users\PC\Desktop\input.txt");
            while ((line = reader.ReadLine()) != null) // lần lượt quét từng dòng của tệp tin
            {
                Console.WriteLine(line); // thực hiện hành động đối với từng dòng dữ liệu, ví dụ in ra
                                         // màn hình, lưu vào biến khác,... 
                // do_something 
            }
            reader.Close(); // Sau khi dùng xong phải đóng đối tượng StreamReader lại. 


            // Khởi tạo StreamWriter để bắt đầu ghi dữ liệu vào tệp tin output.txt
            StreamWriter writer = new StreamWriter(@"C:\Users\PC\Desktop\output.txt");

            // Ghi dữ liệu vào, mỗi lần WriteLine tương ứng với một dòng trong tệp tin. 
            writer.WriteLine("Môn học lập trình Windows");
            writer.WriteLine("Đây là dòng số 2 của tệp tin");
            writer.WriteLine("Đây là dòng cuối cùng của tệp tin");

            writer.Close(); // Sau khi dùng xong phải đóng đối tượng StreamWriter lại. 

            return 1;
        }
    }
}


