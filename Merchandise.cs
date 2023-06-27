using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public abstract class Merchandise : Product
    {
        public Merchandise(string name, double price, int points) : base(name, price, points)
        {
        }

        public Merchandise(string name, double price, int points , string color) : base(name, price, points)
        {
        }
    }
}
