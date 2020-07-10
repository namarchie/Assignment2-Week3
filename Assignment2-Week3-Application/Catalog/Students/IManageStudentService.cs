using Assignment2_Week3_Application.Catalog.Students.Dtos.Manage;
using Assignment2_Week3_Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Week3_Application.Catalog.Students
{
    public interface IManageStudentService
    {
        Task<int> Create(StudentCreateRequest request);
        Task<int> Update(StudentUpdateRequest request);
        Task<int> Delete(int studentId);
        Task<StudentViewModel> GetById(int studentId);
        Task<PagedResult<StudentViewModel>> GetAll();
        Task<PagedResult<StudentViewModel>> GetAllPaging(GetStudentPagingRequest request);
    }
}
