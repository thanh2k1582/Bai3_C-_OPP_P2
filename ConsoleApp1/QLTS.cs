using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class QLTS
    {
        private List<ThiSinh> ListThiSinh = null;
        public QLTS()
        {
            ListThiSinh = new List<ThiSinh>();
        }
        public void NhapTS()
        {
            ThiSinh thisinh = new ThiSinh();
            Console.WriteLine("Nhap thong tin thi sinh ");
            Console.Write("Nhap so bao danh: ");
            thisinh.SBD = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            thisinh.HoTen = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap dia chi: ");
            thisinh.DiaChi = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap muc uu tien : ");
            thisinh.MucUuTien = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Khoi thi : ");
            Console.WriteLine("******************************");
            Console.WriteLine("* 1.Khoi A                   *");
            Console.WriteLine("* 2.Khoi B                   *");
            Console.WriteLine("* 3.Khoi C                   *");
            Console.WriteLine("******************************");
            Console.Write("Nhap tuy chon : ");
            int n = Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    thisinh.khoiThi = " A (Toan - Ly - Hoa)";
                    break;
                case 2:
                    thisinh.khoiThi = " B (Toan - Hoa - Sinh)";
                    break;
                case 3:
                    thisinh.khoiThi = " C (Van - Su - Dia)";
                    break;
            }

            ListThiSinh.Add(thisinh);
        }

        //Tìm kiếm
        public List<ThiSinh> timTheoSBD(String keyword)
        {
            List<ThiSinh> searchResult = new List<ThiSinh>();
            foreach (ThiSinh thisinh in ListThiSinh)
            {
                if (thisinh.SBD.ToUpper().Contains(keyword.ToUpper()))
                {
                    searchResult.Add(thisinh);
                }
            }
            return searchResult;
        }

        //Xuất
        public void XuatTS(List<ThiSinh> listTS)
        {
            foreach (ThiSinh thisinh in listTS)
            {
                Console.WriteLine("Ma thi sinh: {0}", thisinh.SBD);
                Console.WriteLine("Ho va ten : {0}", thisinh.HoTen);
                Console.WriteLine("Dia chi : {0}", thisinh.DiaChi);
                Console.WriteLine("Muc uu tien: {0}", thisinh.MucUuTien);
                Console.WriteLine("Khoi thi: {0}", thisinh.khoiThi);
            }
            Console.WriteLine();
        }
        public List<ThiSinh> getListThiSinh()
        {
            return ListThiSinh;
        }
    }
}
