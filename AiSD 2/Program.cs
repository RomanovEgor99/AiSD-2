using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiSD_2
{
    class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("Введите Фамилию студента:");
            string lastName = Console.ReadLine();
            Char[] arrLastName;
            arrLastName = lastName.ToCharArray(0,lastName.Length);

            Console.WriteLine("Введите имя студента");
            string firstName = Console.ReadLine();
            Char[] arrFirstName;
            arrFirstName = firstName.ToCharArray(0, firstName.Length);

            Console.WriteLine("Введите id студента:");
            int studentId = Convert.ToInt32(Console.ReadLine());






        }
    }
}
