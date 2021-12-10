using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
        public enum Type { Current, Saving };
        class BankAccount
        {
            private Type accountType;
            private double balance;
            private static long id = 0;
            private long number;
            public long ID()
            {
                return id++;
            }
        public BankAccount(Type accountType, double balance)
        {
            number = ID();
            this.accountType = accountType;
            this.balance = balance;
            Console.WriteLine($"Ваш баланс: {balance};  Тип банковского счета: {accountType}; Номер банковского счета: {number}");
        }
        public double Deposit(double summa, BankAccount bankAccount)
        {
            balance += summa;
            return balance;
        }
        public double WithDrow(double summa, BankAccount bankAccount)
        {
            if (balance >= summa)
            {
                balance -= summa;
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
            return balance;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            BankAccount account = obj as BankAccount;
            if (account != null && account.accountType == accountType && account.balance == balance)
            {
                return true;
            }
            return false;
        }
        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            if (account1.Equals(account2) && account2.Equals(account1))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            if (account1.Equals(account2) && account2.Equals(account1))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"{number}. Тип: {accountType}, баланс: {balance}";
        }
    }
}
