using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public string  CommuneName { get; set; }
        public string DistrictName { get; set; }
        public string ProvinceName { get; set; }

    }
}
