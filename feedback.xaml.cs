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
using Windows.UI.Popups;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using SQLite.Net.Attributes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace login_form
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class feedback : Page
    {

        string path;
        SQLite.Net.SQLiteConnection conn;
        public feedback()
        {

  
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db4.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<table6>();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;

        }
        public class table6
        {
            [PrimaryKey]

            public string name { get; set; }
            public string Email { get; set; }
            public string adicom { get; set; }
           
        }
        private async void feedback1_Click(object sender, RoutedEventArgs e)
        {
            var pop = new MessageDialog("Thanx for the feedback");
            await pop.ShowAsync();
            Frame.Navigate(typeof(home));
            var s = conn.Insert(new table6()
            {
                name = txt1.Text,
                Email = txt2.Text,
                adicom = txt3.Text


            });
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }

        }
    }
}
