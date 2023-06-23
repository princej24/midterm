using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace midterm
{
    public abstract class Drinks : Product
    {


      public enum Drinksize {  small , larg , big }
        Drinksize _size;

    //protected Drinks(string name, double price, int points, Drinksize size): base(name, price, points)
    //    {
    //     //  _size = size;
    //    }

        protected Drinks(string name, double price, int points, Drinksize size) : base(name, price, points)
        {
            _size = size;
        }




        public override string ToString()
        {
            return base.ToString() +$"- Drink Size- {_size}";
        }
    }

}
