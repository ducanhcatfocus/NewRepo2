using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NameAndAge();
            calDaysBeforeBD();
            Console.ReadKey();
        }

        private static void NameAndAge()
        {
            string name;
            int year;
            Console.WriteLine("Nhap ten: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            year = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - year;

            Console.WriteLine(name + " " + age.ToString());
        }

        private static void calDaysBeforeBD()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Nhap ngay sinh: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang sinh: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nam sinh: ");
            Console.ReadLine();
            int currentYear = DateTime.Now.Year;

            if (month < now.Month || (month == now.Month && day < now.Day )) currentYear++;
        
            DateTime bd = new DateTime(currentYear, month, day);
            TimeSpan result = bd - now;
            Console.WriteLine("Con " + result.Days + " ngay toi sn cua ban");            
        }
    }
}
