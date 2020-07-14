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
using Assginment2_Week3_Api.Services;
using Microsoft.Extensions.Configuration;

namespace Assginment2_Week3_Api.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //private readonly IStudentService _manageStudentService;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public HomeController(IStudentService manageStudentService)
        //{
        //    _manageStudentService = manageStudentService;
        //}
        private readonly IConfiguration _configuration;
        private readonly IStudentService _studentService;
        public HomeController (IConfiguration configuration, IStudentService studentService)
        {

            _configuration = configuration;
            _studentService = studentService;

        }
        [HttpGet]
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetStudentPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _studentService.GetStudentsPagings(request);
            ViewBag.province = await _studentService.GetAllProvince();
            ViewBag.district = await _studentService.GetAllDistrict();
            ViewBag.commune = await _studentService.GetAllCommune();
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Create( StudentCreateRequest request)
        {
            var productId = await _studentService.Create(request);
            if (productId == 0)
                return BadRequest();


            return RedirectToAction("Index");
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete( int Id)
        {
            var student = await _studentService.Delete(Id);
            if (student == 0)
                return BadRequest();
            return Ok(student);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(StudentUpdateRequest request)
        {
            var productId = await _studentService.Update(request);
            if (productId == 0)
                return BadRequest();
            return Ok(productId);
        }


    }
}
