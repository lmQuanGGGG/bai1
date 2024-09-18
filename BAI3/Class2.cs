using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3
{
    internal class Student : Person
    {
        public float DTB { get; set; }
        public string Khoa { get; set; }
        public Student() { }

        public Student(float dTB, string khoa)
        {
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
