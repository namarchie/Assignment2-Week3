using Assignment2_Week3_Application.Catalog.Students.Dtos.Manage;
using Assignment2_Week3_Application.Dtos;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assginment2_Week3_Api.Services
{
    public class ApiClient : IApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        public ApiClient(IHttpClientFactory httpClientFactory,IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }
        //public async Task<PagedResult<StudentViewModel>> GetStudentsPagings(GetStudentPagingRequest request)
        //{
        //    var client = _httpClientFactory.CreateClient();
        //    client.BaseAddress = new Uri(_configuration["BaseAddress"]);
        //    var response = await client.GetAsync($"/api/students/paging?pageIndex=" +
        //        $"{request.PageIndex}&pageSize={request.PageSize}&keyword={request.Keyword}");
        //    var body = await response.Content.ReadAsStringAsync();
        //    var students = JsonConvert.DeserializeObject<PagedResult<StudentViewModel>>(body);
        //    return students;
        //}
    }
}
