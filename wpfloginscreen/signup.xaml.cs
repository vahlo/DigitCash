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
using System.Data.SqlClient;
using System.Data;

namespace wpfloginscreen
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Window
    {
        public signup()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Kopplingen till (Viktors) SQL Server
            SqlConnection sqlCon = new SqlConnection("Data Source=VIKTORKLLBOAA42\\SQLEXPRESS;Initial Catalog=LogonDB;Integrated Security=True");
            {
                sqlCon.Open();

                //"Useradd" är query för att lägga till ny person i  vårt table
                SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                
                sqlCmd.CommandType = CommandType.StoredProcedure;
                

                //Lägger in värderna från användaren till rätt positioner i tabelen

                sqlCmd.Parameters.AddWithValue("@UserID", txtUserID.Text.Trim()); //Trim tar bort mellanslag i början evt slutet
                sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password.Trim());
                sqlCmd.ExecuteNonQuery(); //exicute ovanstående
                MessageBox.Show("Registration is Sucessfull");
                Clear();

            }

            void Clear()
            {
                txtUsername.Text = txtUserID.Text = txtPassword.Password = "";
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen logOut = new LoginScreen();
            logOut.Show();
            this.Close();
        }
    }
}
