using Assignment_Week3_Common.Exceptions;
using Assignment2_Week3_Application.Catalog.Students.Dtos.Manage;
using Assignment2_Week3_Application.Dtos;
using Assignment2_Week3_Data.EF;
using Assignment2_Week3_Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Week3_Application.Catalog.Students
{
    public class StudentService : IStudentService
    {
        private readonly StudentDbContext _context;
        public StudentService(StudentDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(StudentCreateRequest request)
        {
            var province =  _context.Provinces.First(x => x.ProvinceName == request.ProvinceName);
            var commune = _context.Communes.First(x => x.CommuneName == request.CommuneName);
            var district = _context.Districts.First(x => x.DistrictName == request.DistrictName);

            var student = new Student()
            {
                Name = request.Name,
                Yob = request.Yob,
                Address = request.Address + ", " + request.CommuneName + ", " + request.DistrictName + ", " + request.ProvinceName,
                Phone = request.Phone,
                DistrictId = district.DistrictId,
                ProvinceId = province.ProvinceId,
                CommuneId = commune.CommuneId
            };
            _context.Students.Add(student);
             await _context.SaveChangesAsync();
            return student.Id;
            
        }

        public async Task<int> Delete(int studentId)
        {
            var student = await _context.Students.FindAsync(studentId);
            if (student == null) throw new StudentException("Can not find the student");
            _context.Students.Remove(student);
            return await _context.SaveChangesAsync();

        }

        public async Task<PagedResult<StudentViewModel>> GetAll()
        {
            var student =  _context.Students.Select(x => new StudentViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Yob = x.Yob,
                Phone = x.Phone,
                Address = x.Address,
            });
            int totalRow = await student.CountAsync();
            var pageResult = new PagedResult<StudentViewModel>()
            {
                TotalRecord = totalRow,
                Items = await student.ToListAsync()
            };
            return pageResult;

        }

        public async Task<PagedResult<StudentViewModel>> GetStudentsPagings(GetStudentPagingRequest request , int sort)
        {
            var student = _context.Students.Select(x => new StudentViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                Yob = x.Yob,
                Phone = x.Phone,
                Address = x.Address,
            });
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                student = student.Where(p => p.Name.Contains(request.Keyword));
            }
            if (sort==1)
            {
                student = student.OrderBy(x => x.Yob);
            }
            if (sort == 2)
            {
                student = student.OrderBy(x => x.Name);
            }
            int totalRow = await student.CountAsync();
            var data = student.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize);
            var pageResult = new PagedResult<StudentViewModel>()
            {
                TotalRecord = totalRow,
                Items = await data.ToListAsync()
            };
            return pageResult;



        }

        public async Task<StudentViewModel> GetById(int Id)
        {
            var student = await _context.Students.FindAsync(Id);
            var studentViewModel = new StudentViewModel()
            {
                Id = Id,
                Name = student.Name,
                Yob = student.Yob,
                Address = student.Address,
                Phone = student.Phone,
                
            };
            return studentViewModel;
        }

        public async Task<int> Update(StudentUpdateRequest request)
        {
            var province = _context.Provinces.First(x => x.ProvinceName == request.ProvinceName);
            var district = _context.Districts.First(x => x.DistrictName == request.DistrictName);
            var commune = _context.Communes.First(x => x.CommuneName == request.CommuneName);
            var student = await _context.Students.FindAsync(request.Id);
            if (student == null) throw new StudentException("Can not find the student");
            student.Name = request.Name;
            student.Phone = request.Phone;
            student.Yob = request.Yob;
            //string[] arr = request.Address.Split(',');
            //string address = null;
            //for (int i = 0; i < arr.Length-3; i++)
            //{
            //    address += arr[i] + ",";
            //}
            student.Address = request.Address + ", " + province.ProvinceName + ", " + district.DistrictName + ", " + commune.CommuneName;
            student.CommuneId = commune.CommuneId;
            student.DistrictId = district.DistrictId;
            student.ProvinceId = province.ProvinceId;
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProvinceViewModel>> GetAllProvince()
        {
            var province = _context.Provinces.Select(x => new ProvinceViewModel()
            {
                ProvinceId = x.ProvinceId,
                ProvinceName = x.ProvinceName,
            }) ;
            int totalRow = await province.CountAsync();
            var pageResult = new PagedResult<ProvinceViewModel>()
            {
                TotalRecord = totalRow,
                Items = await province.ToListAsync()
            };
            return pageResult;
        }

        public async Task<PagedResult<DistrictViewModel>> GetAllDistrict()
        {
            var district = _context.Districts.Select(x => new DistrictViewModel()
            {
                DistrictId = x.DistrictId,
                DistrictName = x.DistrictName,
                ProvinceId = x.ProvinceId,
            });
            int totalRow = await district.CountAsync();
            var pageResult = new PagedResult<DistrictViewModel>()
            {
                TotalRecord = totalRow,
                Items = await district.ToListAsync()
            };
            return pageResult;
        }

        public async Task<PagedResult<CommuneViewModel>> GetAllCommune()
        {
            var commune = _context.Communes.Select(x => new CommuneViewModel()
            {
                CommuneId = x.CommuneId,
                CommuneName = x.CommuneName,
                DistrictId = x.DistrictId,
            }) ;
            int totalRow = await commune.CountAsync();
            var pageResult = new PagedResult<CommuneViewModel>()
            {
                TotalRecord = totalRow,
                Items = await commune.ToListAsync()
            };
            return pageResult;
        }
        vfdnvdnvdsdfgvbadhgadfh
    




        //Task<List<StudentViewModel>> IManageStudentService.GetAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
