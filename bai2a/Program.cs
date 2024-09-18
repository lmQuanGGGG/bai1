using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            List<Student> a = new List<Student>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("===========MENU============");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Hien thi danh sach sinh vien");
                Console.WriteLine("3. Hien thi danh sach sinh vien thuoc khoa CNTT");
                Console.WriteLine("4. Hien thi danh sach sinh vien diem trung binh > 5 ");
                Console.WriteLine("5. Hien thi danh sach sinh vien diem trung binh tang dan ");
                Console.WriteLine("6. Hien thi danh sach sinh vien DTB > 5 thuoc khoa CNTT");
                Console.WriteLine("7. Hien thi danh sach sinh vien co DTB cao nhat");
                Console.WriteLine("8. Xep loai sinh vien");
                Console.WriteLine("0. Thoat");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        AddStd(a);
                        break;
                    case "2":
                        foreach (Student st in a)
                        {
                            st.OPSV();
                        }
                        break;
                    case "3":
                        var dssvCNTT = a.Where((st => st.Khoa == "CNTT")).ToList();
                        dssvCNTT.ForEach(st => st.OPSV());
                        if (dssvCNTT.Count == 0)
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                    case "4":
                        var dssvDTB = a.Where((st => st.DTB >5)).ToList();
                        dssvDTB.ForEach(st => st.OPSV());
                        if (dssvDTB.Count == 0)
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                    case "5":
                        var dssvsort = a.OrderBy(x => x.DTB).ToList();
                        dssvsort.ForEach(st => st.OPSV());
                        break;
                    case "6":
                        var dssvDTBCNTT = a.Where((x=> x.Khoa == "CNTT" && x.DTB > 5)).ToList();
                        dssvDTBCNTT.ForEach(st => st.OPSV());
                        break;
                    case "7":
                        var DTBMAX = a.Where((st => st.Khoa == "CNTT")).ToList();
                        if (DTBMAX.Count > 0)
                        {
                            var dtbmax = DTBMAX.Max(st => st.DTB);
                            var ketqua = DTBMAX.Where(x => x.DTB == dtbmax).ToList();
                            ketqua.ForEach(st => st.OPSV());
                        }
                        else
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Ket thuc chuong trinh");
                        break;
                }
            }
        }
        public static void AddStd(List<Student> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            Student student = new Student();
            student.IPSV();
            students.Add(student);
            Console.WriteLine("Them sinh vien thanh cong");
        }
    }
}
