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
    public sealed partial class cse_courses : Page
    {
        public cse_courses()
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

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(b_tech));
        }

        private void hd_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s2.Text);
           
        }

        private void hb_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s1.Text);
        }

        private void hf_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s3.Text);
        }

        private void hh_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s4.Text);
        }

        private void hj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s5.Text);
        }

        private void hl_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s6.Text);
        }

        private void hn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s7.Text);
        }

        private void hp_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s8.Text);
        }

        private void hr_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s9.Text);
        }

        private void ha_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s1.Text);
        }

        private void hc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s2.Text);
        }

        private void he_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s3.Text);
        }

        private void hg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s4.Text);
        }

        private void ht_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s10.Text);
        }

        private void ib_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss.Text);
        }

        private void id_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss2.Text);
        }

        private void iff_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss3.Text);
        }

        private void ih_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss4.Text);
        }

        private void ij_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss5.Text);
        }

        private void il_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss6.Text);
        }

        private void inn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss7.Text);
        }

        private void ip_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss8.Text);
        }

        private void ir_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss9.Text);
        }

        private void it_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss10.Text);
        }

        private void iv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ss11.Text);
        }

        private void ha_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void hi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s5.Text);
        }

        private void hk_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s6.Text);
        }

        private void hm_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s7.Text);
        }

        private void ho_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s8.Text);
        }

        private void hq_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s9.Text);
        }

        private void hs_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s10.Text);
        }

        private void hu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), s11.Text);
        }

        private void ia_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss.Text);
        }

        private void ic_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss2.Text);
        }

        private void ie_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss3.Text);
        }

        private void ig_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss4.Text);
        }

        private void ii_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss5.Text);
        }

        private void ik_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss6.Text);
        }

        private void im_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss7.Text);
        }

        private void io_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss8.Text);
        }

        private void iq_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss9.Text);
        }

        private void iss_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss10.Text);
        }

        private void iu_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ss11.Text);
        }

        private void ja_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss.Text);
        }

        private void jb_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss.Text);
        }

        private void jc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss2.Text);
        }

        private void jd_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss2.Text);
        }

        private void je_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss3.Text);
        }

        private void jf_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss3.Text);
        }

        private void jh_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss4.Text);
        }

        private void jg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss4.Text);
        }

        private void ji_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss5.Text);
        }

        private void jj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss5.Text);
        }

        private void jk_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss6.Text);
        }

        private void jl_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss6.Text);
        }

        private void jm_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss7.Text);
        }

        private void jn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss7.Text);
        }

        private void jp_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss8.Text);
        }

        private void jo_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss8.Text);
        }

        private void jr_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss9.Text);
        }

        private void jq_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss9.Text);
        }

        private void jt_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss10.Text);
        }

        private void js_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss10.Text);
        }

        private void jv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), sss11.Text);
            
        }

        private void ju_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), sss11.Text);
        }

        private void hv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), s11.Text);
        }

        private void ka_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss.Text);
        }

        private void kb_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss.Text);
        }

        private void kc_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss2.Text);
        }

        private void kd_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss2.Text);
        }

        private void ke_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss3.Text);
        }
        private void kf_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss3.Text);
        }

        private void kg_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss4.Text);
        }

        private void kh_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss4.Text);

        }

        private void ki_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss5.Text);
        }

        private void kj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss5.Text);
        }

        private void kk_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss6.Text);
        }

        private void kl_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss6.Text);
        }

        private void km_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss7.Text);
        }

        private void kn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss7.Text);

        }

        private void ko_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss8.Text);
        }

        private void kp_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss8.Text);
        }

        private void kq_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss9.Text);
        }

        private void kr_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss9.Text);
        }

        private void ks_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss10.Text);
        }

        private void kt_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss10.Text);
        }

        private void ku_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(downlaod), ssss11.Text);
        }

        private void kv_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(upload_link), ssss11.Text);
        }

    
    }
    }

