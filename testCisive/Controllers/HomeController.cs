using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Text;
using testCisive.Models;

namespace testCisive.Controllers
{
    public class HomeController : Controller
    {

     

        private readonly ILogger<HomeController> _logger;
        Uri _baseAddress = new Uri("https://localhost:7246/api/Verification/");
        private readonly HttpClient _httpClient;
        public HomeController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = _baseAddress;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("EmployeeForm");
        }


        //[HttpGet]
        //public IActionResult Create()
        //{
        //    Employee employee = new Employee();

        //    return View(employee);
           
        //}

        public IActionResult EmployeeForm()
        { 
        
        return View();
        }

     //   [HttpPost]
//        public IActionResult Create(Employee? employee)
  //      {
            
            //List<Employee> cust = new List<Employee>();

            //HttpContent body = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

            
            //HttpResponseMessage response = _httpClient.PostAsync( _httpClient.BaseAddress + "AddEmployee",body).Result;

          
            



            //if (response.IsSuccessStatusCode)
            //{

            //    string result = response.Content.ReadAsStringAsync().Result;
            //    var data = JsonConvert.DeserializeObject<List<Employee>>(result);

            //    if (data != null && data.Count > 0)
            //    {
            //        cust = data;
            //    }


            //}
            //return Json(new { data = cust });



       // }


        public IActionResult Privacy()
        {
            return View("EmployeeForm");
        }

       
    }
}
