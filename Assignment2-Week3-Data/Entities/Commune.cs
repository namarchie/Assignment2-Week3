using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Entities
{
    public class Commune
    {
        public int CommuneId { set; get; }
        public string CommuneName { set; get; }
        public int DistrictId { get; set; }
        public District District { get; set; }
    }
}
