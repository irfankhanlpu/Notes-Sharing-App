using System;
using System.Collections.Generic;
using Windows.UI.Popups;
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
    public sealed partial class sign_up : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;
        
        public sign_up()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<irfan>();
        }


        public class irfan
        {
            [PrimaryKey]
          
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string cnf { get; set; }
            public string uname { get; set; }
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            {
                if (irff == null)
                    return;
                var combo = (ComboBox)sender;
                var item = (ComboBoxItem)combo.SelectedItem;

            }
        }

        private async void signup1_Click(object sender, RoutedEventArgs e)
        {
            bool x = true;
            var query = conn.Table<irfan>();
            foreach (var message in query)
            {
                if (TB1.Text == message.uname)
                {
                    var dialog = new MessageDialog("This username already exist");
                    await dialog.ShowAsync();
                    x = false;
                    break;
                }
                if (TB4.Text == message.Email)
                {
                    var dialog = new MessageDialog("this email already exists");
                    await dialog.ShowAsync();
                    x = false;
                    break;
                }
            }
            if (x == true)
            {
                var a = conn.Insert(new irfan()
                {
                    Fname = TB5.Text,
                    Email = TB4.Text,
                    Password = TB2.Password,
                    Lname = TB6.Text,
                    cnf = TB3.Password,
                    uname = TB1.Text


                });

                //  conn.Query<table5>("INSERT INTO notes VALUES(?,?,?,?)", TB5.Text, TB6.Text, TB4.Text, TB2.Password);
                var dialog = new MessageDialog("signup successfully");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(login));


            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
          if (this.Frame.CanGoBack)
            {
                this.Frame.GoBack();
            }
        }

        private void tnc_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TERM_CONDITION));
        }
    }
}
