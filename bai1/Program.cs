using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Chuong Trinh Doan So ===");
            Random rnd = new Random();
            int tgnum = new Random().Next(100, 999);
            string tgstring = tgnum.ToString();
            int attempt = 1, MAX_GUES = 7;
            string guess, feedback = "";
            while (feedback != "+++" && attempt <= MAX_GUES)
            {
                Console.Write("Lan thu {0} ", attempt);
                guess = Console.ReadLine();
                feedback = GetFeedBack(tgstring, guess);
                Console.WriteLine("Phan hoi tu may tinh {0} ", feedback);
                attempt++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. Tro choi ket thuc!", attempt - 1);
            if (attempt > MAX_GUES)
                Console.WriteLine("Nguoi choi thua cuoc. So can doan la {0} ", tgnum);
            else Console.WriteLine("Nguoi choi thnag cuoc!", attempt);
            Console.ReadLine();
        }
        static string GetFeedBack(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                    feedback += "+";
                else
                    if (target.Contains(guess[i].ToString())) 
                feedback += "?";
            }
            return feedback;
        }
    }
}