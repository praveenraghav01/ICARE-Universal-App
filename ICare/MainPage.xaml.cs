using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using Newtonsoft.Json;
using System.Text;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ICare
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Uri sugga = new Uri("http://www.vrijraj.xyz/nearhost.html");
            webview.Navigate(sugga);
        }
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private async void first(object sender, RoutedEventArgs e)
        {
          //  User user = new User();
          //  user.PersonId = Convert.ToInt16(username.Text);
          //  user.LastName = password.Password;
          //  HttpClient httpClient = new HttpClient();
          //  httpClient.BaseAddress = new Uri("http://localhost:63298/");
          //  httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            // Limit the max buffer size for the response so we don't get overwhelmed
          //  httpClient.MaxResponseContentBufferSize = 266000;
          //  string mydata = JsonConvert.SerializeObject(user);
          //  var content = new StringContent(
          //    mydata,
           //   Encoding.UTF8,
           //   "application/json");
           // await httpClient.PostAsync("api/apis/addrecord", content);
            this.Frame.Navigate(typeof(HomePage));
        }

        private void getreg(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Reg));
        }

        private void tip(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HealthCare));
        }
        private void con(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(contact));
        }
    }
}
