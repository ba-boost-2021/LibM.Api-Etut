using LibM.Common.Dtos;

namespace LibM.Services.Abstractions
{
    public interface IStudentService
    {
        List<StudentDto> ListStudentByGrade(Guid gradeId);
    }
}
