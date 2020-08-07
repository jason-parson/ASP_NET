using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace ASP_NET.Models
{
    public class Insured
    {
        public Insured()
        {
        }

        public int INSURED_CODE { get; set; }
        public string IFNAME { get; set; }
        public string ILNAME { get; set; }
        public int AGE { get; set; }

        public string ADDRESS { get; set; }

        public string VIN_NUM { get; set; }

        public string CAR_MAKE { get; set; }

        public string CAR_MODEL { get; set; }

        public int CAR_YEAR  {get; set; }

        public int POLICY_NUMBER { get; set; }


    }
}
