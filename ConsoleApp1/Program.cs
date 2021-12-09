using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QLTS quanLyThiSinh = new QLTS();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY THI SINH THI TRUNG HOC PHO THONG");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them thi sinh.                                **");
                Console.WriteLine("**  2. Tim kiem thi sinh theo so bao danh.           **");
                Console.WriteLine("**  3. Hien thi danh sach thi sinh.                  **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        quanLyThiSinh.NhapTS();
                        Console.WriteLine("\nThem cong nhan thanh cong!");
                        break;
                    case 2:
                        Console.Write("\nNhap ma bao danh de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<ThiSinh> searchResult1 = quanLyThiSinh.timTheoSBD(name);
                        quanLyThiSinh.XuatTS(searchResult1);
                        break;

                    case 3:
                        quanLyThiSinh.XuatTS(quanLyThiSinh.getListThiSinh());
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
}
