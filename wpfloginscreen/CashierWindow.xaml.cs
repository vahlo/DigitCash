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

namespace wpfloginscreen
{
    /// <summary>
    /// Interaction logic for CashierWindow.xaml
    /// </summary>
 
    public partial class CashierWindow : Window
    {
        public CashierWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_logout(object sender, RoutedEventArgs e)
        {
            LoginScreen logOut = new LoginScreen();
            logOut.Show();
            this.Close();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button0.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button1.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button2.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button3.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button4.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button5.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button6.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button7.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button8.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Textbox.Text = Textbox.Text + button9.Content;
        }

        private void Button_Click_add(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_mult(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_reciept(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_checkout(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_cancel(object sender, RoutedEventArgs e)
        {
            Textbox.Text = "";
        }
    }
}
