using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GaodeSpotViewHelp
{
    public static class GaodeSpotViewMaster
    {
        public class photo
        {
            public  photo()
            {
                Title = "-1";
                Url = "-1";
            }
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
            {
                Id = "-1";
                Name = "-1";
                Type = "-1";
                Address = "-1";
                Lng = "-1";
                Lat = "-1";
                Pname = "-1";
                Cityname = "-1";
                Adminname = "-1";
                Rating = "-1";
                Cost = "-1";
                Telephone = "-1";
            }

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

        /// <summary>
        /// 生成景点csv文件
        /// </summary>
        /// <param name="city">城市拼音</param>
        /// <param name="key">高德AK</param>
        /// <param name="filePath">文件保存路径</param>
        public static void GenerateCsvFile(string city,string key,string filePath)
        {
            CreatCSV(filePath);
            int count, page, left;
            string Count_string = "0";
            String xml_firstdata = "0";
            string pre_web = "http://restapi.amap.com/v3/place/text?keywords=%E6%99%AF%E7%82%B9&city=";
            string mid_web1 = "&output=xml&offset=20&page=";
            string mid_web2 = "&key=";
            string post_web = "&extensions=all";
            string web = pre_web + city + mid_web1 + 1 + mid_web2 + key + post_web;
            xml_firstdata = GetResponseWithhttpGet(web);
            Count_string = ReadCount(xml_firstdata);
            count = Convert.ToInt32(Count_string);//获得景点总数
            page = count / 20;//获得页码，默认每页20个景点
            left = count - page * 20;
            String[] xmldata = new string[page + 1];
            for (int i = 1; i < page + 2; i++)
            {
                web = pre_web + city + mid_web1 + i + mid_web2  + key + post_web;
                xmldata[i - 1] = GetResponseWithhttpGet(web);
            }
            List<poi> PoiData = new List<poi>();
            List<photo> PhotoData = new List<photo>();
            for (int j = 0; j < page; j++)
            {
                ReadXmlNodes(xmldata[j], PoiData, PhotoData);
                SaveCSV(filePath, PoiData, PhotoData);
            }
            ReadXmlNodes(xmldata[page], PoiData, PhotoData);
            SaveLastCSV(filePath, PoiData, PhotoData, left);
        }

        static string GetResponseWithhttpGet(string urlString)
        {
            var client = new RestClient(urlString);
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "ec2f8a13-4be9-713e-9d11-4ba67316086d");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            string content = response.Content;
            return content;
        }

        static string ReadCount(string Xmldata)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Xmldata);
            XmlNode xnresponse = xmlDoc.SelectSingleNode("response");
            string count = (xnresponse.SelectSingleNode("count")).InnerText;
            return count;
        }
        static void ReadXmlNodes(string Xmldata, List<poi> PoiData, List<photo> PhotoData)
        {
            /*
            List<poi> PoiData = new List<poi>();
            List<photo> PhotoData = new List<photo>();
            */
            poi p1 = new poi();
            PoiData.Add(p1);
            photo p2 = new photo();
            PhotoData.Add(p2);
            int i = 0;
            int j = 0;
            string t = null;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(Xmldata);
            XmlNode xnresponse = xmlDoc.SelectSingleNode("response");
            XmlNodeList xnList = xnresponse.ChildNodes;
            foreach (XmlNode xn in xnList)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.Name == "pois")
                {
                    XmlNodeList xnList2 = xe.ChildNodes;
                    foreach (XmlNode xn2 in xnList2)
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
                        foreach (XmlNode xn3 in xnList3)
                        {
                            XmlElement xe3 = (XmlElement)xn3;
                            if (xe3.Name == "biz_ext")
                            {
                                t = (xn3.SelectSingleNode("rating")).InnerText;
                                if (t != "")
                                    PoiData[i].Rating = (xn3.SelectSingleNode("rating")).InnerText;
                                t = (xn3.SelectSingleNode("cost")).InnerText;
                                if (t != "")
                                    PoiData[i].Cost = (xn3.SelectSingleNode("cost")).InnerText;
                            }
                            if (xe3.Name == "photos")
                            {
                                XmlNodeList xnList4 = xe3.ChildNodes;
                                foreach (XmlNode xn4 in xnList4)
                                {
                                    t = (xn4.SelectSingleNode("title")).InnerText;
                                    if (t != "")
                                        PhotoData[j].Title = (xn4.SelectSingleNode("title")).InnerText;
                                    t = (xn4.SelectSingleNode("url")).InnerText;
                                    if (t != "")
                                        PhotoData[j].Url = (xn4.SelectSingleNode("url")).InnerText;
                                    j++;
                                    if (j == PhotoData.Count)
                                    {
                                        photo p3 = new photo();
                                        PhotoData.Add(p3);
                                    }

                                }
                            }
                        }
                        i++;
                        poi p4 = new poi();
                        PoiData.Add(p4);
                        if (j != 3 * i)
                        {
                            int x = j;
                            j = 3 * i;
                            for (int k = 0; k < j - x; k++)
                            {
                                photo p5 = new photo();
                                PhotoData.Add(p5);
                            }

                        }


                    }
                }
            }
        }

        static void CreatCSV(string filePath)
        {
            string str = "id,name,type,address,lng,lat,pname,cityname,adminname,biz_ext_rating,biz_ext_cost,telephone,photourl1,photourl2,photourl3";
            FileStream fs = new FileStream(filePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
            sw.WriteLine(str);
            sw.Close();
            fs.Close();
        }

        static void SaveCSV(string filePath, List<poi> PoiData, List<photo> PhotoData)
        {
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            for (int i = 0; i < 20; i++)
            {
                data = PoiData[i].Id + "," + PoiData[i].Name + "," + PoiData[i].Type + "," + PoiData[i].Address + "," + PoiData[i].Lng + "," + PoiData[i].Lat + "," + PoiData[i].Pname + "," + PoiData[i].Cityname + "," + PoiData[i].Adminname + "," + PoiData[i].Rating + "," + PoiData[i].Cost + "," + PoiData[i].Telephone + "," + PhotoData[3 * i].Url + "," + PhotoData[3 * i + 1].Url + "," + PhotoData[3 * i + 2].Url;
                sw.WriteLine(data);
                sw.Flush();
            }
            sw.Close();
            fs.Close();
        }

        static void SaveLastCSV(string filePath, List<poi> PoiData, List<photo> PhotoData, int left)
        {
            FileStream fs = new FileStream(filePath, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string data;
            for (int i = 0; i < left; i++)
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
