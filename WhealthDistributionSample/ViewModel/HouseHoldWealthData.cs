using Microsoft.VisualBasic;
using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WhealthDistributionSample
{
    public class HouseHoldWealthData
    {
        public ObservableCollection<WealthData> Bottom50Data { get; set; }

        public ObservableCollection<WealthData> Next40 { get; set; }

        public ObservableCollection<WealthData> Top9 { get; set; }

        public ObservableCollection<WealthData> Top1 { get; set; }

        public ObservableCollection<WealthData> TopPoint1 { get; set; }


        public HouseHoldWealthData()
        {

            Bottom50Data = new ObservableCollection<WealthData>();
            Next40 = new ObservableCollection<WealthData>();
            Top9 = new ObservableCollection<WealthData>();
            Top1 = new ObservableCollection<WealthData>();
            TopPoint1 = new ObservableCollection<WealthData>();
            //Collection = new ObservableCollection<ChartModel>();
            ReadCSV();
        }
    

        public void ReadCSV()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("WhealthDistributionSample.dfanetworthlevels.csv");
            List<string> lines = new List<string>();
            if (inputStream != null)
            {
                string line;
                StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(0);

                //double _bottom50 = 0, _next40 = 0, _top9 = 0, _top1 = 0, _topPoint1 = 0;


                foreach (var dataPoint in lines)
                {
                    string[] data = dataPoint.Split(',');

                    string[] date = data[0].Split(':');

                    switch(data[1])
                    {
                        case "Bottom50":
                            Bottom50Data.Add(new WealthData(date[0], Convert.ToDouble(data[2])));
                            break;
                        case "Next40":
                            Next40.Add(new WealthData(date[0], Convert.ToDouble(data[2])));
                            break;
                        case "Next9":
                            Top9.Add(new WealthData(date[0], Convert.ToDouble(data[2])));
                            break;
                        case "RemainingTop1":
                            Top1.Add(new WealthData(date[0], Convert.ToDouble(data[2])));
                            break;

                        default:
                            TopPoint1.Add(new WealthData(date[0], Convert.ToDouble(data[2])));
                            break;
                    }

                }

            }

        }
    }

}
