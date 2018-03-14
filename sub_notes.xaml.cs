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
    public sealed partial class sub_notes : Page
    {
        public sub_notes()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string)
            {
                hid1.Text = e.Parameter.ToString();
            }
            else
            {
                hid1.Text = "";
            }
            //base.OnNavigatedTo(e);
        }

        private void a1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(b_tech));
        }

        private void a2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(bse));
        }
        private void a3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(bcome_courses));
        }


        private void a4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(hotal_courses));
        }

        private void a5_Click(object sender, RoutedEventArgs e)
        {

        }


        private void a6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(home));
        }
    }
}
