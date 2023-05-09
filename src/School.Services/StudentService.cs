using Dapper;
using Microsoft.Extensions.Configuration;
using School.DataModel;
using School.Services.Interfaces;
using System.Data.SqlClient;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        private readonly IConfiguration _config;
        private readonly string _connString;

        public StudentService(IConfiguration configuration)
        {
            _config = configuration;
            _connString = _config.GetConnectionString("SchoolConnection");
        }
        public IEnumerable<Student> Get()
        {
            IEnumerable<Student> students = new List<Student>();    

            try
            {
                string query = "dbo.GetStudents";
                using (var sqlConn = new SqlConnection(_connString))
                {
                    students = sqlConn.Query<Student>(query, commandType: System.Data.CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {

            }

            return students;
        }
    }
}