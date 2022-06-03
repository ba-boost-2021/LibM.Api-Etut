using LibM.Common.Dtos;
using LibM.Data.Context;
using LibM.Services.Abstractions;

namespace LibM.Services.Concretes
{
    internal class StudentService : IStudentService
    {
        private readonly LibMDbContext dbContext;

        public StudentService(LibMDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<StudentDto> ListStudentByGrade(Guid gradeId)
        {
            var result = dbContext.Grades.Where(x => x.Id == gradeId).Select(x => x.Students).FirstOrDefault();
            return result.Select(x=> new StudentDto { Age = x.Age, Name = x.FirstName}).ToList();
        }
    }
}