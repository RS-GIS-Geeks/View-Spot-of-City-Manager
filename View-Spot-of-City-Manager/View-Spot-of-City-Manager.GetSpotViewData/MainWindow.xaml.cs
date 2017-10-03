using RestSharp;
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

namespace View_Spot_of_City_Manager.GetSpotViewData
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=1&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
        }

        public string GetResponseWithhttpGet(string urlString)
        {
            var client = new RestClient(urlString);
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "ec2f8a13-4be9-713e-9d11-4ba67316086d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            return content;
        }
    }
}
