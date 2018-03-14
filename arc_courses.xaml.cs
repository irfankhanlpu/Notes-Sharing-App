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
    public sealed partial class arc_courses : Page
    {
        public arc_courses()
        {
            this.InitializeComponent();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listitemone.IsSelected)
                txtShowDataOnClickOfListItems.Text = "List Item One is clicked.";

            if (listitemtwo.IsSelected)
                txtShowDataOnClickOfListItems.Text = "List Item two is clicked.";
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            /* if (myView.IsPaneOpen)
                 myView.IsPaneOpen = false;
             else
                 myView.IsPaneOpen = true; */

            myView.IsPaneOpen = !myView.IsPaneOpen;
        }



        private void s111_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s100_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s99_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s88_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s77_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s66_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s55_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s44_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s33_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s22_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void s1111_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss4_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss6_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss7_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss8_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss9_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ss10_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            
            if (listitemone1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item One is clicked.";

            if (listitemtwo1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item two is clicked.";

        }
        private void btnClick1_Click(object sender, RoutedEventArgs e)
        {
            /* if (myView.IsPaneOpen)
                 myView.IsPaneOpen = false;
             else
                 myView.IsPaneOpen = true; */

            myView1.IsPaneOpen = !myView1.IsPaneOpen;
        }

        private void btnClick2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void sss2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss4_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss6_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss7_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss8_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss9_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss10_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sss11_Click(object sender, RoutedEventArgs e)
        {
            
        }



        private void ListBox_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {
            if (listitemone1_3.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item One is clicked.";

            if (listitemtwo_3.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item two is clicked.";


        }

        private void btnClick2_Click_1(object sender, RoutedEventArgs e)
        {
            /* if (myView.IsPaneOpen)
                            myView.IsPaneOpen = false;
                        else
                            myView.IsPaneOpen = true; */

            myView2.IsPaneOpen = !myView2.IsPaneOpen;
        }

        private void ssss2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss3_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss4_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss5_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss6_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss7_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss8_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss9_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss10_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ssss11_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(b_tech));
        }
        private void ListBox_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

            if (listitemone1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item One is clicked.";

            if (listitemtwo1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item two is clicked.";

        }

        private void btnClick3_Click(object sender, RoutedEventArgs e)
        {
            {
                /* if (myView.IsPaneOpen)
                     myView.IsPaneOpen = false;
                 else
                     myView.IsPaneOpen = true; */

                myView3.IsPaneOpen = !myView3.IsPaneOpen;
            }
        }
    }
}
