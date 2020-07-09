using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Application.Catalog.Students.Dtos.Manage
{
    public class StudentCreateRequest
    {
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
