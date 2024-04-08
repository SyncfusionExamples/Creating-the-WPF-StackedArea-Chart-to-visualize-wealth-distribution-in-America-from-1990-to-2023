using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhealthDistributionSample
{
    public class WealthData
    {
        public string Date { get; set; }

        public double Value { get; set; }
        public double Bottom50 { get; set; }
        public double Next40 { get; set; }
        public double Top9 { get; set; }
        public double Top1 { get; set; }
        public double TopPoint1 { get; set; }

        public WealthData(string date, double value)
        {
            Date = date;
            Value = value;
        }
        public WealthData(string date, double bottom50, double next40, double top9, double top1,double toppoint1)
        {
            Date = date;
            Bottom50 = bottom50;
            Next40 = next40;
            Top9 = top9;
            Top1 = top1;
            TopPoint1 = toppoint1;
        }
    }
}
