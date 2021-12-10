using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace met13
{
    class Buildings
    {
        private static Buildings[] buildings = new Buildings[10];
        public Buildings this[int index]
        {
            get { return buildings[index]; }
            set { buildings[index] = value; }
        }
    }
}
