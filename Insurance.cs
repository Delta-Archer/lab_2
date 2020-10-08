using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2.Models
{
    public class Insurance
    {
        public int InsuranceID { get; set; }
        public string Client { get; set; }
        public string Type { get; set; }
        public int Sum { get; set; }
    }
}