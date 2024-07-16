using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using testCisive.Models;


namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VerifyEmployementController : ControllerBase
    {
        List<Employee> employees = new List<Employee>();

        public VerifyEmployementController()
        {
            employees.Add(new Employee { Id = 1, Name = "Ajay", Code = "A" });
            employees.Add(new Employee { Id = 2, Name = "Bob", Code = "B" });
            employees.Add(new Employee { Id = 3, Name = "Chintu", Code = "C" });
            employees.Add(new Employee { Id = 4, Name = "Dolu", Code = "D" });

        }



        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return employees;

        }



        [HttpPost]
        public IActionResult VerifyEmployee(Employee ex)
        {
            string status = "";

            employees.Add(new Employee {Id=1,Name="Ajay",Code="A" });
            employees.Add(new Employee { Id = 2, Name = "Bob", Code = "B" });
            employees.Add(new Employee { Id = 3, Name = "Chintu", Code = "C" });
            employees.Add(new Employee { Id = 4, Name = "Dolu", Code = "D" });

            var x = employees.Where(x=>x.Code==ex.Code.ToUpper()).Any();
            if (!x)
            {

                status = "Not Verified";
            }
            else
            {
                status = "Verified";
            }

        return Ok(status);
           
        }
    }
}
