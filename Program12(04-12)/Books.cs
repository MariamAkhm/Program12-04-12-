using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program12_04_12_
{
    class Books
    {
        public string Name { get;set; }
        public string Author { get;set; }
        public string Publishing { get;set; }
        public Books(string name, string author, string publishing)
        {
            Name = name;
            Author = author;
            Publishing = publishing;
        }
        public override string ToString()
        {
            return $"{Name} {Author} {Publishing}";
        }

    }
}
