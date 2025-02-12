using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentClass> GetAllStudents()
        {
            return DataSource();
        }

        public StudentClass GetStudentById(int id)
        {
            return DataSource().Where(x=> x.rollNo == id).FirstOrDefault();
        }
        private List<StudentClass> DataSource()
        {
            return new List<StudentClass>
            {
                new StudentClass { rollNo = 1, Name = "Rohan" ,Gender = "Male" , Standard = 11},
                new StudentClass { rollNo = 2, Name = "LAlit" ,Gender = "Male" , Standard = 10},
                new StudentClass { rollNo = 3, Name = "Sujal" ,Gender = "Male" , Standard = 9},
               new StudentClass { rollNo = 4, Name = "Diya" ,Gender = "Female" , Standard = 12}
            };
        }
    }
}
