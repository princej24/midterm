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
