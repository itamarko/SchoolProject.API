using School.DataModel;
using School.Services.Interfaces;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> students = new List<Student>()
            {
                new Student() { Id = 1, FirstName = "Petar", LastName = "Petrovic"},
                new Student() { Id = 2, FirstName = "Mira", LastName = "Mirkovic"},
            };

            return students;
        }
    }
}