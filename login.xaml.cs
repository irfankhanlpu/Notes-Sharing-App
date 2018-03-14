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
    public sealed partial class login : Page
    {
        string path;
        SQLite.Net.SQLiteConnection conn;

        public login()
        {

            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            conn = new SQLite.Net.SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            //conn.CreateTable<notes>();

        }
        
        private void signup_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(sign_up));
        }

            private void backl_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void t4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TERM_CONDITION));
        }

        public class irfan
        {
            [PrimaryKey]
          
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }

        private async void loginbutton_Click(object sender, RoutedEventArgs e)
        {

            bool x = true;

            var search = conn.Table<irfan>();
            foreach (var message in search)
            {
                if (message.Email == TB1.Text && message.Password == TB2.Password)
                {
                    if (TB1.Text != "" && TB2.Password != "")
                    {
                        this.Frame.Navigate(typeof(home), TB1.Text);
                        x = false;
                        break;
                    }

                    else
                    {
                        var dialog = new MessageDialog("please enter username and password");
                        await dialog.ShowAsync();
                        x = false;
                        break;
                    }
                }

            }
            if (x == true)
            {
                var dialog = new MessageDialog("Please Enter valid Username or password");
                await dialog.ShowAsync();
            }
           else
            {
                MediaElement mediaElement = new MediaElement();
                var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("hello mister   "+TB1.Text +"   "+" . Welcome to this Application . You can download and upload your notes while selecting the MY notes option");
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
        }

        private void t5_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(admin_login));

        }
    }
}
