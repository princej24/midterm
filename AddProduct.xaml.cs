using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace midterm
{
    /// <summary>
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        public AddProduct()
        {
            InitializeComponent();
            lbProducts.ItemsSource = Data.Products;
            PopulateSizeComboBox();
        }

        void PopulateSizeComboBox()
        {
            cbsize.Items.Add("short");
            cbsize.Items.Add("Tall");
            cbsize.Items.Add("Grande");
            cbsize.Items.Add("Venti");
            cbsize.Items.Add("Trenta");
            cbsize.SelectedIndex = 0;
        }

        private void btntestAddpd_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            double price = rand.Next(1,11) +rand .NextDouble();
            int point = rand.Next(100, 1001);

            Tea tea = new Tea("black tea ", price, point,(Drinks.Drinksize) rand.Next(0, 4));

            Data.AddProductToCollection(tea);
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
           


        }

        private void btnTea_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            Drinks.Drinksize chosenSize = (Drinks.Drinksize)cbsize.SelectedIndex;


            Data.AddProductToCollection(new Tea(name, price, points, chosenSize));
        }

        private void btncoffee_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            Drinks.Drinksize chosenSize = (Drinks.Drinksize)cbsize.SelectedIndex;


            Data.AddProductToCollection(new Coffe(name, price, points, chosenSize));
        }

        private void btnLunch_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            double price = double.Parse(txtPrice.Text);
            int points = int.Parse(txtPoints.Text);
            bool heated = rbHeated.IsChecked ?? false;

            
            Data.AddProductToCollection(new Lunch(name, price, points, heated));
        }

        private void btnBreakfast_Click(object sender, RoutedEventArgs e)
        {
           
                string name = txtName.Text;
                double price = double.Parse(txtPrice.Text);
                int points = int.Parse(txtPoints.Text);
                bool heated = rbDairy_.IsChecked ?? true;
            
            Data.AddProductToCollection(new Breakfast(name, price, points, heated));



        }


        private bool hasDairy;
        private bool heated;

        private void rbDairy_Checked(object sender, RoutedEventArgs e)
        {
            hasDairy = true;
        }

        //private void rbDairy_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    hasDairy = false;
        //}

        private void rbHeated_Checked(object sender, RoutedEventArgs e)
        {
            heated = true;
        }

        private void btnMug_Click(object sender, RoutedEventArgs e)
        {
            

            string color = txtColor.Text;
            Mug mug = new Mug("Mug Item", 9.99, 5, color);


            Data.AddProductToCollection(mug);
        }

        private void btnTumbler_Click(object sender, RoutedEventArgs e)
        {
            
            string color = txtColor.Text;
            Tumbler tumbler = new Tumbler("Mug Item", 8.99, 5, color);


            Data.AddProductToCollection(tumbler);
        }
        //private void rbHeated_UnChecked(object sender, RoutedEventArgs e)
        //{
        //    heated = false;
        //}
    }
}
