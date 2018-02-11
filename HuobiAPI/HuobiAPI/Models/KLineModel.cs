using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuobiAPI.Models
{
    public class KLineModel
    {
        public string ch { get; set; }
        public long ts { get; set; }
        public Tick tick { get; set; }
    }

    public class Tick
    {
        public long id { get; set; }
        public double open { get; set; }
        public double close { get; set; }
        public double low { get; set; }
        public double high { get; set; }
        public double amount { get; set; }
        public double vol { get; set; }
        public double count { get; set; }
    }
}
