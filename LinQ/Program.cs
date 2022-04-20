using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class LinQ
    {
        static int Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<string> listName = new List<string>();

            listName.Add("Hồng Thái Bình");
            listName.Add("Huỳnh Kim Ngân");
            listName.Add("Huỳnh Lý Hữu Phúc");
            listName.Add("Huỳnh Tiến Đạt");
            listName.Add("Lê Bùi Phương An");
            listName.Add("Nguyễn Hữu Thuận");
            listName.Add("Nguyễn Minh Huy");
            listName.Add("Nguyễn Phạm Minh Huy");
            listName.Add("Nguyễn Phi Khang");
            listName.Add("Nguyễn Sơn Thành Danh");
            listName.Add("Nguyễn Trần Quân");
            listName.Add("Nguyễn Võ Xuân Phong");
            listName.Add("Nông Văn Tình");
            listName.Add("Phạm Minh Khang");
            listName.Add("Trần Như Ngọc");
            listName.Add("Trần Phạm Đông Quân");
            listName.Add("Trịnh Đào Gia Hiếu");
            listName.Add("Võ Huỳnh Tuyến");
            listName.Add("Vũ Nhật Chương");
            listName.Add("Vũ Trung Nam");
            listName.Add("Nguyễn Lê Huy Phất");

            // Tìm danh sách tên bắt đầu bằng họ Nguyễn
            IEnumerable<string> queryResult0 = listName.Where(x => x.StartsWith("Nguyễn"));
            foreach (string queryResultItem in queryResult0)
            {
                Console.WriteLine(queryResultItem);
            }

            Console.WriteLine("===========================");

            // Tìm danh sách tên có độ dài lớn hơn 20
            IEnumerable<string> queryResult = from name in listName 
                                              where name.Length > 20  
                                              select name;



            foreach (string queryResultItem in queryResult)
            {
                Console.WriteLine(queryResultItem);
            }

            Console.WriteLine("===========================");

            // Tìm danh sách tên có độ dài >= 16 và <= 21
            IEnumerable<string> queryResult2 = from name in listName
                                              where name.Length >= 16 && name.Length <= 21
                                              select name;

            foreach (string queryResultItem in queryResult2)
            {
                Console.WriteLine(queryResultItem);
            }


            List<Customer> list = new List<Customer>();
            list.Add(new Customer() { Country = "India", Status = "A" });
            list.Add(new Customer() { Country = "USA", Status = "A" });

            // Tìm danh sách Customer có Country là USA
            IEnumerable<Customer> queryResult3 = list.Where(x => x.Country == "USA");


            // Tìm danh sách Customer có Country khác USA và có Status là A
            IEnumerable<Customer> queryResult4 = list.Where(x => x.Country != "USA" && x.Status == "A");


            Console.WriteLine("===========================");
            foreach (Customer queryResultItem in queryResult3)
            {
                Console.WriteLine(queryResultItem.ToString());
            }

            Console.WriteLine("===========================");
            foreach (Customer queryResultItem in queryResult4)
            {
                Console.WriteLine(queryResultItem.ToString());
            }

            return 1;
        }
    }

    class Customer
    {
        public string? Country { get; set; }
        public string? Status { get; set; }

        
        public override string ToString()
        {
            return string.Format("Country {0}, Status {1}", this.Country, this.Status);
        }
    }
}
