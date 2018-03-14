using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net.Attributes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace login_form
{



    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class upload_link : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public upload_link()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db1.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<irfan3>();
        }
        public class irfan3
        {
            public string textblock { get; set; }
            public string  name{ get; set; }
            public string link { get; set; }
        }

        private void loginbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void loginbutton_Click_1(object sender, RoutedEventArgs e)
        {

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

        private async void loginbutton_Click_2(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Thanx for submission");
            await dialog.ShowAsync();
            var s=conn.Insert(new irfan3()
            { 
                    textblock = t2.Text,
                    name = TB1.Text,
                    link=TB2.Text


                });

            
           
        }

        private void back2_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }
    }
}
