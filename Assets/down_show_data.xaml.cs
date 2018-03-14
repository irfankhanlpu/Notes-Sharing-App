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

namespace login_form.Assets
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class down_show_data : Page
    {
        public down_show_data()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string)
            {
                t2.Text = e.Parameter.ToString();
            }
            else
            {
                t2.Text = " of ";
            }
            //base.OnNavigatedTo(e);
        }

        private void seelink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void back3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(cse_courses));
        }
    }
}
