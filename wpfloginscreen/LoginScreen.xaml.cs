using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace wpfloginscreen
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Kopplingen till DB
            SqlConnection sqlCon = new SqlConnection("Data Source=VIKTORKLLBOAA42\\SQLEXPRESS;Initial Catalog=LogonDB;Integrated Security=True");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                //Väljer första raden den hittar 1 i tabluser där  argumentet stämmer
                String query = "SELECT COUNT(1) FROM tbluser WHERE UserID=@UserID AND Password=@Password";


                // Skapar ett objekt "sqlCmd" med två parametrar, //Sätter egenskaperna för sqlCmd (text?)
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                
                //Kollar userinput från boxarna mot UserID och password i tabelen
                sqlCmd.Parameters.AddWithValue("@UserID",txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);

                //Sätter count till värde 1 (true)
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());


                string UserCheck = txtUsername.Text;

                if (count == 1)
                {

                    string admin = "5";
                    string sales = "3";
                    string casher = "2";

                    if (UserCheck.Substring(0,1) == admin)
                    
                    {
                        MessageBox.Show("Welcome Admin with UserID nr : " + UserCheck);
                        //Skickar Admin till signup window
                        signup newUser = new signup();
                        newUser.Show();
                        this.Close();
                    }

                    else if (UserCheck.Substring(0, 1) == casher)

                    {
                        MessageBox.Show("Welcome casher, with userID : " + UserCheck);
                        //Skickar till Kassa window
                        CashierWindow cash = new CashierWindow();
                        cash.Show();
                        this.Close();

                    }

                    else if (UserCheck.Substring(0, 1) == sales)

                    {
                        MessageBox.Show("Welcome Sales, with userID : " + UserCheck);
                        //Skickar till main window
                        MainWindow dashboard = new MainWindow();
                        dashboard.Show();
                        this.Close();

                    }

                }

                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            //tb.GotFocus -= TextBox_GotFocus;
        }
        //public void TextBox_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    TextBox tb = (TextBox)sender;
        //    tb.Text = tb.Text;
        //}
    }
}
