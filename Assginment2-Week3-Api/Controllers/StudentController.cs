using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2_Week3_Application.Catalog.Students;
using Assignment2_Week3_Application.Catalog.Students.Dtos.Manage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assginment2_Week3_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IManageStudentService _manageStudentService;
        public StudentController(IManageStudentService manageStudentService)
        {
            _manageStudentService = manageStudentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var student = await _manageStudentService.GetAll();
            return Ok(student);
        }
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetById(int studentId)
        {
            var student = await _manageStudentService.GetById(studentId);
            if (student == null)
                return BadRequest("Cannot find the student");
            return Ok(student);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]StudentCreateRequest request)
        {
            var studentId = await _manageStudentService.Create(request);
            if (studentId == 0)
                return BadRequest();
            var student = await _manageStudentService.GetById(studentId);
            return CreatedAtAction(nameof(GetById),new { id = studentId },student);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] StudentUpdateRequest request)
        {
            var affected = await _manageStudentService.Update(request);
            if (affected == 0)
                return BadRequest();
            return Ok();
        }
        [HttpDelete("{studentId}")]
        public async Task<IActionResult> Delete(int studentId)
        {
            var affected = await _manageStudentService.Delete(studentId);
            if (affected == 0)
                return BadRequest();
            return Ok();
        }

    }
}
