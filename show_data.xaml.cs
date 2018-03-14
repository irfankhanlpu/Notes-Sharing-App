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
using SQLite.Net.Attributes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
namespace login_form
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class show_data : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public show_data()
        {
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db1.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<retrieve>;
        }
        public class irfan3
        {
            public string textblock { get; set; }
            public string name { get; set; }
            public string link { get; set; }
        }

      
       
        private void rt1_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<irfan3>();
            string tb = "";
            string na = "";
            string lk = "";

            foreach (var message in query)
            {
                tb = tb + " " + "\n"+message.textblock;
                na = na + " " +"\n"+ message.name;
                lk = lk + " " +"\n" +message.link;


            }

            t1.Text = "\n Subject \n" +tb ;
            t2.Text =  "\n name \n"+na;
            t3.Text= "\n link \n" + lk;
        }

        private void back1_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(show_data2));
        }

        private void back2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(show_data3));
        }

        private void back3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(login));
        }
    }
}
