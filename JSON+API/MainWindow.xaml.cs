using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace JSON_API
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string key = "3b5ae7f192eee2751d4c10d69cf0012c";
        string town = "";
        string url = "http://api.openweathermap.org/data/2.5/weather?q=";
        public MainWindow()
        {
            InitializeComponent();
        }

        public void getInf()
        {
            string url_tmp = url + town + "&units=metric&appid=" + key + "&lang=ru";
            var webRequest = WebRequest.Create(url_tmp);
            var responseStream = webRequest.GetResponse().GetResponseStream();
            string answer = "";
            if (responseStream != null)
            {
                using (var streamReader = new StreamReader(responseStream))
                {
                    answer = streamReader.ReadLine();
                }
                Ans ans = JsonConvert.DeserializeObject<Ans>(answer);
                to_tb(ans);
            }
        }

        private void Bt_know_Click(object sender, RoutedEventArgs e)
        {
            town = tb_city.Text;
            getInf();
        }

        private void to_tb(Ans ans)
        {
            tb_information.Text = "В городе " + town + " следующая погода:\n\n";
            tb_information.Text += "Температура: " + ans.main.Temp.ToString() + "°";
        }
    }
}
