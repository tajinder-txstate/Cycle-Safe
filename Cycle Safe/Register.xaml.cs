using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static Cycle_Safe.Globalclass;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Cycle_Safe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {

        public Register()
        {
            this.InitializeComponent();
        }

        private void Name_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if(Name_TextBox.Text == "Name")
                Name_TextBox.Text = string.Empty;
        }

        private void Email_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if (Email_TextBox.Text == "Email")
                Email_TextBox.Text = string.Empty;
        }

        private void Phone_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if(Phone_TextBox.Text == "Phone Number")
                Phone_TextBox.Text = string.Empty;
        }

        private void UserName_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if(UserName_TextBox.Text == "Username")
                UserName_TextBox.Text = string.Empty;
        }

        private void Password_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if(Password_TextBox.Text == "Password")
                Password_TextBox.Text = string.Empty;
        }

        private void Verify_TextBox_Click(object sender, PointerRoutedEventArgs e)
        {
            if(Verify_TextBox.Text == "Verify Password")
                Verify_TextBox.Text = string.Empty;
        }

        private void Name_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_TextBox.Text))
                Name_TextBox.Text = "Name";
            fullname = Name_TextBox.Text;
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Email_TextBox.Text))
                Email_TextBox.Text = "Email";
            email = Email_TextBox.Text;
        }

        private void Phone_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Phone_TextBox.Text))
                Phone_TextBox.Text = "Phone Number";
            phone = Phone_TextBox.Text;
        }

        private void UserName_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName_TextBox.Text))
                UserName_TextBox.Text = "Username";
            username = UserName_TextBox.Text;
        }

        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Password_TextBox.Text))
                Password_TextBox.Text = "Password";
        }

        private void VerifyPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Verify_TextBox.Text))
                Verify_TextBox.Text = "Verify Password";
        }

        private bool PassValidate(string pass, string verify)
        {
            if (Password_TextBox.Text == Verify_TextBox.Text)
            {
                password = Password_TextBox.Text;
                return true;
            }
            else
                return false;

        }
    }
}
