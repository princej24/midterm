using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace midterm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
           // Gold_Member memeber = new  Gold_Member ("jeff ", "fjef");

            
            cbMembers.ItemsSource = Data.Members;
            lBProducts.ItemsSource= Data.Products;

        }
        //adds product 
        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            new AddProduct().Show();// brings the othe page 

        }
        //adds menber 
        private void btnAddMember__Click(object sender, RoutedEventArgs e)
        {
            new AddMember().Show();// brings the othe page 

        }

        private void cbMembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Member selectedmember = (Member)cbMembers.SelectedItem;
            Data.UpdateTocurrentMember(selectedmember);
            //add the list to the itemsource 

            lbPreviousTransactions.ItemsSource = Data.CurrentMember.PreviousTransaction1;

        }

        private void btBuy_product__Click(object sender, RoutedEventArgs e)
        {
            if (Data.CurrentProduct != null &Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct);
                Data.CurrentMember.AddPoints(Data.CurrentProduct);
                cbMembers.Items.Refresh();

            }
        }

        private void lBProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product currentlyselected = (Product)lBProducts.SelectedItem;
            Data.UpdateTocurrentProduct(currentlyselected);
        }

        private void btnUsePoints__Click(object sender, RoutedEventArgs e)
        {
            if (Data.CurrentProduct != null & Data.CurrentMember != null)
            {
                Data.CurrentMember.AddProduct(Data.CurrentProduct);
                Data.CurrentMember.DeductPoints(Data.CurrentProduct);
                cbMembers.Items.Refresh();

            }
        }

      
    }
}
