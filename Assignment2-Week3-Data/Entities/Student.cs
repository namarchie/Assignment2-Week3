using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        //public string AddressFull { get; set; }
        public int CommuneId { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }


    }
}
