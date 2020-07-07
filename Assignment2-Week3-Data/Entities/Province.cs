using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Entities
{
    public class Province
    {
        public int ProvinceId {set;get;}
        public string ProvinceName { set; get; }
        public List<District> Districts { get; set; }
    }
}
