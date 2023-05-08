using School.BusinessModel;
using System.Net;

namespace School.BusinessLogic.Interfaces
{
    public interface IStudentBusinessLogic
    {
        List<Student> GetAllStudents();
    }
}