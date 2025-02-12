using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public interface IStudent
    {
        List<StudentClass> GetAllStudents();
        StudentClass GetStudentById(int id);
    }
}
