using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI3
{
    internal class Teachers : Person
    {
        public string Diachi { get; set; }

        public Teachers(string diachi)
        {
            Diachi = diachi;
        }
        public Teachers() { }

        public void IPSV()
        {
            MSSV = Console.ReadLine();
            Name = Console.ReadLine();
            Diachi = Console.ReadLine();
        }
        public void OPSV()
        {
            Console.WriteLine("{0} - {1} - {2} ", MSSV, Name, Diachi);
        }
    }
}
