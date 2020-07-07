using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Entities
{
    public class District
    {
        public int DistrictId { set; get; }
        public string DistrictName { set; get; }
        public int ProvinceId { set; get; }
        public Province Province { get; set; }
        public List<Commune> Communes { get; set; }
    }
}
