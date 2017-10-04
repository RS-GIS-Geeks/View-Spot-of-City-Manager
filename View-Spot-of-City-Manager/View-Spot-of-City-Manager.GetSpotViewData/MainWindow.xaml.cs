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
using System.Xml;
using System.IO;
using System.Data;
using ViewSpotData;

namespace ViewSpotData
{
    public class photo
    {
        public photo()
        { }
        public string Title
        {
            get;
            set;
        }
        public string Url
        {
            get;
            set;
        }
    }
    public class poi
    {
        public poi()
        { }

        public string Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string Lng
        {
            get;
            set;
        }
        public string Lat
        {
            get;
            set;
        }
        public string Pname
        {
            get;
            set;
        }
        public string Cityname
        {
            get;
            set;
        }
        public string Adminname
        {
            get;
            set;
        }
        public string Rating
        {
            get;
            set;
        }
        public string Cost
        {
            get;
            set;
        }
        public string Telephone
        {
            get;
            set;
        }
    }

}
namespace GetResponseWithhttp
{

}
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
            string filePath= "d:\\ViewSpotData.txt";
            CreatTXT(filePath);
            String[] xmldata=new string[100];
            xmldata[0] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=1&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[1] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=2&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[2] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=3&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[3] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=4&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[4] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=5&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[5] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=6&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[6] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=7&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[7] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=8&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[8] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=9&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[9] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=10&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[10] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=11&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[11] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=12&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[12] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=13&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[13] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=14&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[14] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=15&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[15] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=16&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[16] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=17&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[17] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=18&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[18] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=19&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[19] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=20&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[20] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=21&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[21] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=22&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[22] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=23&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[23] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=24&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[24] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=25&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[25] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=26&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[26] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=27&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[27] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=28&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[28] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=29&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[29] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=30&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[30] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=31&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[31] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=32&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[32] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=33&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[33] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=34&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[34] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=35&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[35] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=36&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[36] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=37&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[37] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=38&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[38] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=39&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[39] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=40&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[40] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=41&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[41] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=42&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[42] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=43&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[43] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=44&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            xmldata[44] = GetResponseWithhttpGet("http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=shenzhen&output=xml&offset=20&page=45&key=fd763697d93b87991106b8aead5cea7f&extensions=all");
            List<poi> PoiData = new List<poi>();
            List<photo> PhotoData = new List<photo>();
            for (int i=0;i<44;i++)
            {
                ReadXmlNodes(xmldata[i], PoiData, PhotoData);
                SaveTXT(filePath,PoiData, PhotoData);
            }
            ReadXmlNodes(xmldata[44], PoiData, PhotoData);
            SaveLastTXT(filePath, PoiData, PhotoData);
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
        public void ReadXmlNodes(string Xmldata, List<poi> PoiData, List<photo> PhotoData)
        {
            /*
            List<poi> PoiData = new List<poi>();
            List<photo> PhotoData = new List<photo>();
            */
            poi p1= new poi();
            photo p2 = new photo();
            PoiData.Add(p1);
            PhotoData.Add(p2);
            int i = 0;
            int j = 0;
            string t=null;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Xmldata);
            XmlNode xnresponse = xmlDoc.SelectSingleNode("response");
            XmlNodeList xnList = xnresponse.ChildNodes;
            foreach (XmlNode xn in xnList)
            {
                XmlElement xe = (XmlElement)xn;
                if(xe.Name=="pois")
                {
                    XmlNodeList xnList2 = xe.ChildNodes;
                    foreach(XmlNode xn2 in xnList2)
                    {
                        XmlElement xe2 = (XmlElement)xn2;
                        XmlNodeList xnList3 = xe2.ChildNodes;
                        PoiData[i].Id = (xn2.SelectSingleNode("id")).InnerText;
                        PoiData[i].Name = xn2.SelectSingleNode("name").InnerText;
                        PoiData[i].Type = (xn2.SelectSingleNode("type")).InnerText;
                        PoiData[i].Address = (xn2.SelectSingleNode("address")).InnerText;
                        string poiLoc = (xn2.SelectSingleNode("location")).InnerText;
                        PoiData[i].Lng = poiLoc.Substring(0, poiLoc.IndexOf(','));
                        PoiData[i].Lat = poiLoc.Substring(0, poiLoc.LastIndexOf(','));
                        PoiData[i].Pname = (xn2.SelectSingleNode("pname")).InnerText;
                        PoiData[i].Cityname = (xn2.SelectSingleNode("cityname")).InnerText;
                        PoiData[i].Adminname = (xn2.SelectSingleNode("adname")).InnerText;
                        t = (xn2.SelectSingleNode("tel")).InnerText;
                        if (t != "")
                            PoiData[i].Telephone = (xn2.SelectSingleNode("tel")).InnerText;
                        else
                            PoiData[i].Telephone = "-1";
                        foreach (XmlNode xn3 in xnList3)
                        {
                            XmlElement xe3 = (XmlElement)xn3;
                            if (xe3.Name == "biz_ext")
                            {
                                t= (xn3.SelectSingleNode("rating")).InnerText;
                                if (t != "")
                                    PoiData[i].Rating = (xn3.SelectSingleNode("rating")).InnerText;
                                else
                                    PoiData[i].Rating = "-1";
                                t = (xn3.SelectSingleNode("cost")).InnerText;
                                if (t != "")
                                    PoiData[i].Cost = (xn3.SelectSingleNode("cost")).InnerText;
                                else
                                    PoiData[i].Cost = "-1";
                            }
                            if (xe3.Name == "photos")
                            {
                                XmlNodeList xnList4 = xe3.ChildNodes;
                                foreach (XmlNode xn4 in xnList4)
                                {
                                    t= (xn4.SelectSingleNode("title")).InnerText;
                                    if (t != "")
                                        PhotoData[j].Title = (xn4.SelectSingleNode("title")).InnerText;
                                    else
                                        PhotoData[j].Title = "-1";
                                    t = (xn4.SelectSingleNode("url")).InnerText;
                                    if (t != "")
                                        PhotoData[j].Url = (xn4.SelectSingleNode("url")).InnerText;
                                    else
                                        PhotoData[j].Url = "-1";
                                    j++;
                                    if(j==PhotoData.Count)
                                    {
                                        photo p3 = new photo();
                                        PhotoData.Add(p3);
                                    }

                                }
                            }
                        }
                        i++;
                        if (i == PoiData.Count)
                        {
                            poi p4 = new poi();
                            PoiData.Add(p4);
                        }
                        if (j != 3 * i)
                        {
                            int x = j;
                            j = 3 * i;
                            for(int k=0;k<j-x;k++)
                            {
                                PhotoData[x + k].Title = "-1";
                                PhotoData[x + k].Url = "-1";
                                photo p5 = new photo();
                                PhotoData.Add(p5);
                            }

                        }


                    }
                }
            }
        }
        public static void CreatTXT(string filePath)
        {
            string str = "id,name,type,address,lng,lat,pname,cityname,adminname,biz_ext_rating,biz_ext_cost,telephone,photourl1,photourl2,photourl3";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Close();
            fs.Close();
        }
        public static void SaveTXT(string filePath,List<poi> PoiData, List<photo> PhotoData)
        {
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            for (int i = 0; i< 20;i++)
            {
                data = PoiData[i].Id + "," + PoiData[i].Name + "," + PoiData[i].Type + "," + PoiData[i].Address + "," + PoiData[i].Lng + "," + PoiData[i].Lat + "," + PoiData[i].Pname + "," + PoiData[i].Cityname + "," + PoiData[i].Adminname + "," + PoiData[i].Rating + "," + PoiData[i].Cost + "," + PoiData[i].Telephone + "," + PhotoData[3 * i].Url + "," + PhotoData[3 * i + 1].Url + "," + PhotoData[3 * i + 2].Url;
                sw.WriteLine(data);
                sw.Flush();
            }
            sw.Close();
            fs.Close();
        }
        public static void SaveLastTXT(string filePath, List<poi> PoiData, List<photo> PhotoData)
        {
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            for (int i = 0; i < 12; i++)
            {
                data = PoiData[i].Id + "," + PoiData[i].Name + "," + PoiData[i].Type + "," + PoiData[i].Address + "," + PoiData[i].Lng + "," + PoiData[i].Lat + "," + PoiData[i].Pname + "," + PoiData[i].Cityname + "," + PoiData[i].Adminname + "," + PoiData[i].Rating + "," + PoiData[i].Cost + "," + PoiData[i].Telephone + "," + PhotoData[3 * i].Url + "," + PhotoData[3 * i + 1].Url + "," + PhotoData[3 * i + 2].Url;
                sw.WriteLine(data);
                sw.Flush();
            }
            sw.Close();
            fs.Close();
        }
    }
}
