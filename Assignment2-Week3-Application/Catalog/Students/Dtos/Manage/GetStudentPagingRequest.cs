using Assignment2_Week3_Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_Week3_Application.Catalog.Students.Dtos.Manage
{
    public class GetStudentPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }

    }
}
