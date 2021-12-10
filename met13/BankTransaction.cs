using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace met13
{
    class BankTransaction
    {
        private readonly double summa;
        private uint index = 0;
        public uint ID => index;
        public double Summa => summa;
        public BankTransaction(double summa)
        {
            this.summa = summa;
            Console.WriteLine($"Перевод суммы: {summa}; Время: {DateTime.Now}");
            index++;
        }
    }
}
