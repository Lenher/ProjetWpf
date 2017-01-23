using BDDWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace TestBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager.Open();
            UserManager.CleanDB();
            UserManager.Add("Michou", 54);
            UserManager.Add("Nathan", 52);
            UserManager.Add("Cédric", 34);
            UserManager.Add("Axel", 24);
            UserManager.Add("Titouan", 21);
            UserManager.GetAll().ForEach(Console.WriteLine);
            Console.Read();
        }
    }
}
