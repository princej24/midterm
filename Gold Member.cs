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
            throw new NotImplementedException();
        }

        public override void DeductPoints(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
