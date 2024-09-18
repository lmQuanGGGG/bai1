using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI22
{
    public class Student
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public float DTB { get; set; }
        public string Khoa { get; set; }
        public Student() { }

        public Student(string mSSV, string name, float dTB, string khoa)
        {
            MSSV = mSSV;
            Name = name;
            DTB = dTB;
            Khoa = khoa;
        }

        public void IPSV()
        {
            MSSV = Console.ReadLine();
            Name = Console.ReadLine();
            DTB = float.Parse(Console.ReadLine());
            Khoa = Console.ReadLine();
        }
        public void OPSV()
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", MSSV, Name, DTB, Khoa);
        }

    }
}
