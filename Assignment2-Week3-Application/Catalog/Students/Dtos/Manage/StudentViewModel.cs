using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Application.Catalog.Students.Dtos.Manage
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        //public string AddressFull { get; set; }
    }
}
