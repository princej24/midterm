using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Gold_Member : Member
    {
        public Gold_Member(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddPoints(Product product)
        {
            Points += product.Points +50;
        }

        public override void DeductPoints(Product product)
        {
            Points -= (product.Points /2)-50;

        }
    }//class 
}//namespace 
