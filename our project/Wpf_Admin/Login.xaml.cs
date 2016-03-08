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

namespace Wpf_Admin
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //DBAdminEntities db = new DBAdminEntities();

            dbAdminEntities db = new dbAdminEntities();
            var credentials = new {
                username = txtUsername.Text,
            password = passwordBox.Password};
            List<string> userDetails = new List<string>();
            
           
            var select = db.Person.Select(x => new {PLastName = x.PLastName, PEmail = x.PEmail, PUsername = x.PUserName, PPassword = x.PPassword }).Where(userLogins => userLogins.PUsername == credentials.username && userLogins.PPassword == credentials.password);
            foreach (var userDetail in select)
            {
                userDetails.Add(userDetail.PEmail);
                userDetails.Add(userDetail.PLastName);

               

            }
            int count = userDetails.Count;
            if (count > 0)
            {
               
                MainWindow home = new MainWindow();
                App.Current.MainWindow = home;
                this.Close();
                home.Show();

                MessageBox.Show("you have successfully logged in");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to cancel, to go back press OK");




        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
