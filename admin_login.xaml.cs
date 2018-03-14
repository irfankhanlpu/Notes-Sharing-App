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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace login_form
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class admin_login : Page
    {
        public admin_login()
        {
            this.InitializeComponent();
        }
        private void loginbutton_Click(object sender, RoutedEventArgs e)
        {
            if (TB1.Text == "Irfanlpu" && TB2.Password == "Irfan12@")
            {
                Frame.Navigate(typeof(show_data));
            }
        }
    

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(login));
        }
    }

}
