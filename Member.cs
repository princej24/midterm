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
        //feilds 


        string _firstName;
        string _lastName;

        string _memberNumber;
        int _points;

        DateTime _membersince = DateTime.Now;
        ObservableCollection<Product> PreviousTransaction;
        //constuctor

        public Member(string firstName, string lastName)
        {
            Random rand = new Random();
            _firstName = firstName;
            _lastName = lastName;
            _memberNumber = rand.Next(100000, 100000).ToString();
            _membersince = DateTime.Now;
            _points = 0;
            PreviousTransaction = new ObservableCollection<Product>();
        }
        //property

        public ObservableCollection<Product> PreviousTransaction1 { get => PreviousTransaction; }




        // method
        public abstract void DeductPoints(Product product);
        public abstract void AddPoints(Product product);





        public void AddProduct(Product product)
        {
           PreviousTransaction.Add(product); 
        }

        public override string ToString()
        {
            return $"{GetType().Name} -{_firstName}- {_lastName} - {_points} - {_memberNumber}";
        }


    }
}
