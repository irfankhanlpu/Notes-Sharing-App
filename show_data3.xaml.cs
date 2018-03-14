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
    public sealed partial class show_data3 : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        public show_data3()
        {
           
            this.InitializeComponent();
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db4.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<retrieve>;
        }
        public class table6
        {
            [PrimaryKey]

            public string name { get; set; }
            public string Email { get; set; }
            public string adicom { get; set; }

        }

        private void rt3_Click(object sender, RoutedEventArgs e)
        {
            var query = conn.Table<table6>();
            string em = "";
            string ps = "";
            string fn = "";
            foreach (var message in query)
            {
                em = em + "" + "\n" + message.name;
                ps = ps + "" + "\n" + message.Email;
                fn = fn + "" + "\n" + message.adicom;
            }
            t1.Text = "\n Email \n" + em;
            t2.Text = "\n password \n" + ps;
            t3.Text = "\n First Name \n" + fn;

        }

        private void rt4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(show_data));
        }
    }
    }

