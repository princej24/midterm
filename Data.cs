using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace midterm
{
    internal static class Data
    {

        //fields 

        static ObservableCollection<Member> _members;

        static ObservableCollection<Product> _Products;

        static Product currentProduct = null;

        static Member currentMember = null;



        //Constroctor 

        //static constroctor
        static Data()
        {
            _members = new ObservableCollection<Member>();
            _Products = new ObservableCollection<Product>();
            PreLoad();
        }

        public static void  PreLoad()
        {
            //pre load members 
            _members. Add (new Gold_Member ("prince ", "jeff "));
            _members. Add (new Regula_Member ("jason  ", "muturi "));
            //prelaoding products 
            Products.Add(new Tea("milk ", 20, 24,Drinks.Drinksize.larg ));
            Products.Add(new Coffe("water ", 20, 24, Drinks.Drinksize.larg));
            //lading products into member 
            _members[0].AddProduct(_Products[0]);
            _members[1].AddProduct(_Products[1]);


        }



        // properties

        public static ObservableCollection<Member> Members { get => _members; }
        public static ObservableCollection<Product> Products { get => _Products; }
        public static Product CurrentProduct { get => currentProduct; }
        public static Member CurrentMember { get => currentMember; }




        //methods 

        public static void AddProductToCollection(Product product)
        {
            _Products.Add(product);
        }
        public static void AddMemberToCollection(Member member)
        {
            _members.Add(member);


        }


        public static void UpdateTocurrentProduct(Product product)
        {
          currentProduct =product;

        }
        public static void UpdateTocurrentMember(Member member)
        {
            currentMember = member;

        }



    }
}
