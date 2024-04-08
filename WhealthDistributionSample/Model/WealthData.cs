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

        public WealthData(string date, double value)
        {
            Date = date;
            Value = value;
        }
    }
}
