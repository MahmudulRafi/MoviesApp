using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static readonly string[] StudentsName = new[]
        {
            "Mahmudul Hasan Rafi","Mahadi Hasan Rafat","Sazzad Hossain Shorav","Safayat Hossain Bhauiyan","Mauhtasim Fuad","Muhaiminul Islam"
        };

        [HttpGet(Name = "GetStudents")]
        public List<Students> GetStudents()
        {
            List<Students> studentsList = new();
            DateTime initialDate = Convert.ToDateTime("1997-08-15T14:49:50.5997265+06:00");

            for (int i = 1; i <= 6; i++)
            {
                Students student = new();
                student.StudentId = i;
                student.Name = StudentsName[i - 1];
                student.Roll = $"ST{i}";
                student.Email = $"st{i}@imastudent.com";
                student.DateOfBirth = initialDate.AddYears(i);

                studentsList.Add(student);
            }
            return studentsList;
        }
    }
}
