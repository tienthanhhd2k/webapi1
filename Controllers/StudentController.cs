using Microsoft.AspNetCore.Mvc;

namespace netcoreapi1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        private List<Student> _student;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
            _student = new List<Student>
            {
                new Student
                {
                    BirthPlace = "Ha Noi",
                    Gender = "Male",
                    University ="Bach Khoa",
                    StudenName = "Pham Tien Thanh"
                },
                new Student
                {
                    BirthPlace = "Hai Duong",
                    Gender = "Male",
                    University ="Bach Khoa",
                    StudenName = "Do Tien Thanh"
                },
                new Student
                {
                    BirthPlace = "Nam Dinh",
                    Gender = "Male",
                    University ="Bach Khoa",
                    StudenName = "Nguyen Tien Thanh"
                }

            };
        }
        [HttpGet]
        public IEnumerable<Student> Get(string? birthplace)
        {
            if(string.IsNullOrEmpty(birthplace))
                return _student.Where(x=>x.BirthPlace == "Nam Dinh").ToList();
            else
                return _student.Where(x=>x.BirthPlace == birthplace).ToList();
        } 
    }
}