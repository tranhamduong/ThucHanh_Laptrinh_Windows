using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_TH_03 // Note: actual namespace depends on the project name.
{
    class List
    {
        static int Mains(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Syntax: List<Kiểu dữ liệu> list = new List<Kiểu dữ liệu>();
            List<int> listInteger = new List<int>(); // khởi tạo 1 List các số nguyên rỗng
            Console.WriteLine("Danh sách rỗng: {0}", listInteger.Count);

            List<string> listString = new List<string>(); // khởi tạo 1 List các chuỗi rỗng
            Console.WriteLine("Danh sách rỗng: {0}", listString.Count);

            //Thêm phần tử vào cuối List
            // Syntax: list.Add(x); 
            listInteger.Add(0);
            listInteger.Add(1);
            listInteger.Add(2);
            listInteger.Add(3);
            listInteger.Add(4);
            listInteger.Add(5);
            //listInteger.Add("ABC"); // Lỗi, vì listInteger chỉ có thể chứa kiểu dữ liệu số nguyên

            //listString.Add(18); // Lỗi, vì listString chỉ có thể chứa kiểu dữ liệu chuỗi kí tự
            listString.Add("Tống");
            listString.Add("Hữu");
            listString.Add("Định");

            List<int> listInteger_sample = new List<int>(listInteger);

            // Vòng lặp với List, Xuất DS Tất cả phần tử
            // Syntax: dùng vòng lặp for
            for(int i = 0; i < listInteger.Count; i++)
            {
                Console.WriteLine(listInteger[i]);
            }

            foreach (string item in listString)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Chèn phần tử x tại vị trí index
            // Syntax: list.Insert(index, x);
            listInteger.Insert(3, 98); // [1,2,3,4,5] ==> [1,2,3,98,4,5]
            //listInteger.Insert(10, 999); //[1,2,3,4,5] ==> Lỗi
            Console.WriteLine("Danh sách sau khi chèn giá trị {0} tại vị trí {1}:", 98, 3);
            foreach (int item in listInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n====================");
            listInteger = new List<int>(listInteger_sample);

            // Xóa phần tử tại vị trí index
            // Syntax: list.removeAt(index);
            listInteger.RemoveAt(1);
            Console.WriteLine("Danh sách sau khi xoá phần tử tại vị trí {0}:", 1);
            foreach (int item in listInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n====================");
            listInteger = new List<int>(listInteger_sample);

            // Xoá phần tử có giá trị x đầu tiên trong danh sách
            // Syntax: list.remove(x);
            listInteger.Remove(3);
            Console.WriteLine("Danh sách sau khi xoá phần tử có giá trị bằng {0}:", 3);
            foreach (int item in listInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n====================");
            listInteger = new List<int>(listInteger_sample);

            // Sắp xếp danh sách
            // Syntax:list.sort();
            listInteger.Reverse();
            listInteger.Sort();
            Console.WriteLine("Danh sách sau khi sắp xếp:", 3);
            foreach (int item in listInteger)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n====================");
            listInteger = new List<int>(listInteger_sample);

            // Truy vấn vị trí đầu tiên của giá trị x. 
            // Syntax: list.IndexOf(x);
            Console.WriteLine("Vị trí của phần tử {0} trong mảng là: {1}", 3, listInteger.IndexOf(3));
            Console.WriteLine("\n====================");

            // Truy vấn vị trí cuối cùng của giá trị x. 
            // Syntax: list.LastIndexOf(x);
            listInteger.Add(3); // [0, 1, 2, 3, 4, 5, 3]
            Console.WriteLine("Vị trí cuối cùng của phần tử {0} trong mảng là: {1}", 3, listInteger.LastIndexOf(3));

            return 1;
        }
    }
}