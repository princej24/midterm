using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public class Regula_Member : Member
    {
        public Regula_Member(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public override void AddPoints(Product product)
        {
            Points += product.Points;
        }

        public override void DeductPoints(Product product)
        {
            Points -= product.Points;

        }
    }
}
