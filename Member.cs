using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public abstract class Member
    {
        //feilds. 

        string _memberNumber;
        string _firstName;
        string _lastName;
        int _points;

        DateTime _membersince = DateTime.Now;
        ObservableCollection<Product> PreviousTransaction;
        //constuctor

        public Member(string firstName, string lastName)
        {
            Random rand = new Random();
            _firstName = firstName;
            _lastName = lastName;
            _memberNumber = rand.Next(100000, 999999).ToString();

            _membersince = DateTime.Now;
            _points = 0;
            PreviousTransaction = new ObservableCollection<Product>();
        }
        //property

        public ObservableCollection<Product> PreviousTransaction1 { get => PreviousTransaction; }
        protected  int Points { get => _points; set => _points = value; }




        // method
        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);





        public void AddProduct(Product product)
        {
           PreviousTransaction.Add(product); 

        }

        public override string ToString()
        {
            return $"{GetType().Name} -{_firstName}- {_lastName} - point total {_points} - {_memberNumber}";
        }


    }
}
