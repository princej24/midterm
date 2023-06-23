using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Coffe : Drinks
    {
        public Coffe(string name, double price, int points, Drinksize size) : base(name, price, points, size)
        {
        }
    }
}
