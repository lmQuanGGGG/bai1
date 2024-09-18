using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            List<Student> a = new List<Student>();
            List<Teachers> t = new List<Teachers>();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("===========MENU============");
                Console.WriteLine("1. Them sinh vien");
                Console.WriteLine("2. Them Giao Vien");
                Console.WriteLine("3. Hien thi danh sach sinh vien");
                Console.WriteLine("4. Hien thi danh sach giao vien");
                Console.WriteLine("5. Hien thi so luong tung danh sach ");
                Console.WriteLine("6. Hien thi danh sach sinh vien thuoc khoa CNTT");
                Console.WriteLine("7. Hien thi danh sach giao vien co dia chi o Quan 9");
                Console.WriteLine("8. Xuat ra sinh vien cos diem trung binh cao nhat");
                Console.WriteLine("9. Xep loai");
                Console.WriteLine("0. Thoat");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStd(a);
                        break;
                    case "2":
                        AddTch(t);
                        break;
                    case "3":
                        foreach (Student st in a)
                        {
                            st.OPSV();
                        }
                        break;
                    case "4":
                        foreach(Teachers tch in t)
                        {
                            tch.OPSV();
                        }
                        break;
                    case "5":
                        var slsv = a.Count;
                        var slgv = t.Count;
                        Console.WriteLine("So luong Sinh Vien {0} - So luong Giao Vien {1}",slsv, slgv);
                        break;
                    case "6":
                        var dssvCNTT = a.Where((st => st.Khoa == "CNTT")).ToList();
                        dssvCNTT.ForEach(st => st.OPSV());
                        if (dssvCNTT.Count == 0)
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                    case "7":
                        var GVQ9 = t.Where((st => st.Diachi == "Quan 9")).ToList();
                        GVQ9.ForEach(st => st.OPSV());
                        if (GVQ9.Count == 0)
                        {
                            Console.WriteLine("Not Found");
                        }
                        break;
                    case "8":
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
                    case "9":
                        var xuatsac = a.Where((x => x.DTB >= 9 && x.DTB <= 10)).ToList();
                        var gioi = a.Where((x => x.DTB >= 8 && x.DTB < 9)).ToList();
                        var kha = a.Where((x => x.DTB >= 7 && x.DTB < 8)).ToList();
                        var trungbinh = a.Where((x => x.DTB >= 5 && x.DTB < 7)).ToList();
                        var yeu = a.Where((x => x.DTB >= 4 && x.DTB < 5)).ToList();
                        var kem = a.Where((x => x.DTB < 4)).ToList();
                        Console.WriteLine("Xuat sac {0} - Gioi {1} - Kha {2} - Trung Binh {3} - Yeu {4} - Kem {5}", xuatsac.Count,
                            gioi.Count, kha.Count, trungbinh.Count, yeu.Count, kem.Count);
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
        public static void AddTch(List<Teachers> teachers)
        {
            Console.WriteLine("Nhap thong tin giao vien");
            Teachers tch = new Teachers(); 
            tch.IPSV();
            teachers.Add(tch);
            Console.WriteLine("Them giao vien thanh cong");
        }
    }
}
