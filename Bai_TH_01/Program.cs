// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace Bai_TH_01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.ReadLine();

            Program p = new Program();
            p.TimPhanTuMaTranLonNhat();

            return 1;
        }

        public void CongHaiSo()
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;
            Console.WriteLine("Dap an cua phep tinh {0} + {1} la {2}", a, b, c);
        }

        public void NhapHoVaTen()
        {
            Console.WriteLine("Moi ban nhap ho va ten: ");
            string hoVaTen = Console.ReadLine();
            Console.WriteLine("Xin chao {0}.", hoVaTen);
        }


        public void NgayTrongThang()
        {
            Console.WriteLine("Nhap vao thang: ");
            int thang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap vao nam: ");
            int nam = Convert.ToInt32(Console.ReadLine());

            int SoNgayTrongThang = 0;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    SoNgayTrongThang = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    SoNgayTrongThang = 30;
                    break;
                case 2:
                    if (LaNamNhuan(nam) == true)
                    {
                        SoNgayTrongThang = 29;
                    }
                    else
                    {
                        SoNgayTrongThang = 28;
                    }
                    break;
            }

            Console.WriteLine("So ngay trong thang {0} nam {1} la {2}.", thang, nam, SoNgayTrongThang);
        }


        public static bool LaNamNhuan(int nam)
        {
            if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
                return true;
            return false;
        }


        public int[] NhapMang(int n)
        {


            int[] arr = new int[n];
            Console.WriteLine("Nhap mang lan luot theo thu tu: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("In mang ra: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;
        }

        public void TinhTongSoLeTrongMang()
        {
            Console.WriteLine("Nhap kich thuoc mang: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = NhapMang(n);

            int tong = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    tong += arr[i];
                }
            }

            Console.WriteLine("Tong cac so le trong mang: {0}", tong);
        }


        public int[,] NhapMaTran(int m, int n)
        {
            int[,] arr = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Nhap phan tu hang {0} cot {1}:", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return arr;
        }

        public void TimPhanTuMaTranLonNhat()
        {
            Console.WriteLine("Nhap chieu dai ma tran: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhap chieu cao ma tran: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = NhapMaTran(m, n);

            int max = arr[0, 0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }

            Console.WriteLine("So lon nhat trong ma tran la: {0}", max);
        }
    }
}