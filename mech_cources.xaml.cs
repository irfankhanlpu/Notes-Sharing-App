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
    public sealed partial class mech_cources : Page
    {
        public mech_cources()
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

            myView.IsPaneOpen = !myView.IsPaneOpen;
        }

        private void btnClick1_Click(object sender, RoutedEventArgs e)
        {
            myView1.IsPaneOpen = !myView1.IsPaneOpen;
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (listitemone1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item One is clicked.";

            if (listitemtwo1.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item two is clicked.";

        }

        private void s1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void s11_Click(object sender, RoutedEventArgs e)
        {

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
        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(sub_notes));
        }

        private void ListBox_SelectionChanged_13(object sender, SelectionChangedEventArgs e)
        {
            if (listitemone12.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item One is clicked.";

            if (listitemtwo12.IsSelected)
                txtShowDataOnClickOfListItems1.Text = "List Item two is clicked.";

        }

        private void btnClick11_Click(object sender, RoutedEventArgs e)
        {
            myView14.IsPaneOpen = !myView14.IsPaneOpen;
        }

        private void ss22_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss21_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss42_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss52_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss62_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss72_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss82_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss92_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ss102_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
