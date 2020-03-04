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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Exam_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistrationForm : Page
    {
        public RegistrationForm()
        {
            this.InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DisplayInformation), "Username: " + username.Text + "\r\n" + 
                "Nickname: " + name.Text + "\r\n" + 
                "Email: " + email.Text + "\r\n" + 
                "Address: " + address.Text + "\r\n" + 
                "About: " + about.Text);
            //Frame.Navigate(typeof(DisplayInformation), name.Text);
            //Frame.Navigate(typeof(DisplayInformation), email.Text);
        }
    }
}
