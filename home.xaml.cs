using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.UI.Popups;
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
    public sealed partial class home : Page
    {
        public home()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string)
            {
                p1.Text = e.Parameter.ToString();
            } 
            else
            {
                p1.Text = "";
            }
            //base.OnNavigatedTo(e);
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

        private void login_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(login));
        }

        private void sin_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(sub_notes));
        }

      

        private void feedback_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(feedback));
        }


        private async void logout_Click(object sender, RoutedEventArgs e)
        {
            var pop = new MessageDialog("Do u want to logout the session");
            await pop.ShowAsync();
           
            Frame.Navigate(typeof(MainPage));
        }

       
        private void home1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

     

        private void course_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TERM_CONDITION));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(about_us));
        }
    }
}
