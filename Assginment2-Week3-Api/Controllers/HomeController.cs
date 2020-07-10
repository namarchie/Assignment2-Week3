using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assginment2_Week3_Api.Models;
using Assignment2_Week3_Application.Catalog.Students.Dtos.Manage;
using Assignment2_Week3_Application.Catalog.Students;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assginment2_Week3_Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private readonly IManageStudentService _manageStudentService;
        public HomeController(IManageStudentService manageStudentService)
        {
            _manageStudentService = manageStudentService;
        }
        public async Task<IActionResult> Index(string keyword , int pageIndex = 1 , int pageSize = 10)
        {
            var request = new GetStudentPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _manageStudentService.GetAllPaging(request);
            return View(data);
        }

        
    }
}
