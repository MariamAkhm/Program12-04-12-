using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace met13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя первого пользователя:");
            string nameHolder1 = Console.ReadLine();
            Console.WriteLine("Введите баланс ТЕКУЩЕГО счета");
            double balance1 = Convert.ToDouble(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out balance1))
            {
                Console.WriteLine("Неверный ввод, повторите попытку!");
            }
            BankAccount bankAccount1 = new BankAccount(AccountType.Current, balance1, nameHolder1);
            Console.WriteLine("Введите имя второго пользователя:");
            string nameHolder2 = Console.ReadLine();
            Console.WriteLine("Введите баланс СБЕРЕГАТЕЛЬНОГО счета");
            double balance2 = Convert.ToDouble(Console.ReadLine());
            while (!double.TryParse(Console.ReadLine(), out balance2))
            {
                Console.WriteLine("Неверный ввод, повторите попытку!");
            }
            BankAccount bankAccount2 = new BankAccount(AccountType.Saving, balance2,nameHolder2);
            Console.WriteLine("Введите название операции (снять/положить)");
            string answer = Console.ReadLine().ToLower();
            while (!answer.Equals("снять") && !answer.Equals("положить"))
            {
                Console.WriteLine("Неверный ввод, повторите!");
            }
            if (answer.Equals("положить"))
            {
                Console.WriteLine("Введите сумму, которую вы хотите положить на счет 1");
                double summ1 = Convert.ToDouble(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out summ1))
                {
                    Console.WriteLine("Неверный ввод, повторите попытку!");
                }
                bankAccount1.Deposit(summ1, bankAccount1);
            }
            else if (answer.Equals("снять"))
            {
                Console.WriteLine("Введите сумму, которую вы хотите снять со счета 2");
                double summ2 = Convert.ToDouble(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out summ2))
                {
                    Console.WriteLine("Неверный ввод, повторите попытку!");
                }
                bankAccount2.WithDrow(summ2, bankAccount2);
            }
            Console.Clear();

            Console.WriteLine("13.2.1");
            Building building = new Building(32, 7, 28,1);
            building.CountApartmentsInEntrance(28, 1);
        }
    }
}
