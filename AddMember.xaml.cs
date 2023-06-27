using System;
using System.Collections.Generic;
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

namespace midterm
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    public partial class AddMember : Window
    {
        public AddMember()
        {
            InitializeComponent();


            lbmembers.ItemsSource= Data.Members;
        }

        private void lbmembers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Member selectedmember = (Member)lbmembers.SelectedItem;
            Data.UpdateTocurrentMember(selectedmember);
            //add the list to the itemsource 

            lbPreviousTransaction.ItemsSource = Data.CurrentMember.PreviousTransaction1;

        }

        private void btntestAddmem_Click(object sender, RoutedEventArgs e)
        {

            string firstname = txtmemFirstname_.Text;
            string lastname = txtMemLastName.Text;
           // Data.AddMemberToCollection(new Regula_Member(firstname, lastname));

            Random rand = new Random();
            if (rand.Next(0,2)==0)
            {
                //Data.AddMemberToCollection(new Gold_Member("prince ", "muturi"));
                Data .AddMemberToCollection(new Gold_Member(firstname, lastname));

            }
            else
            {
               // Data.AddMemberToCollection(new Regula_Member("jake ", "prince "));
                Data.AddMemberToCollection(new Regula_Member(firstname, lastname));
                txtmemFirstname_.Text = "";
                txtMemLastName.Text = "";
            }
           

        }

        private void rbRegularmember__Checked(object sender, RoutedEventArgs e)
        {
            rbRegularmember_.IsChecked = false;// clears immediately after clicked but still takes the input 

        }

        private void rbGoldmember__Checked(object sender, RoutedEventArgs e)
        {
            rbGoldmember_.IsChecked = false;// clears immediately after clicked but still takes the input 


        }
    }
}
