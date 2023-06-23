using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public abstract class Food : Product
    {
        public Food(string name, double price, int points) : base(name, price, points)
        {
        }
    }
}
