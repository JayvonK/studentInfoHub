using studentInfoHub.Models;

namespace studentInfoHub.Services.StudentServ;

    public interface IStudentService
    {
        List<Student> GetStudents();

        List<Student> SearchStudent(string name);

        List<Student> AddStudent(string name, string grade);

        List<Student> UpdateStudent(string studentName, string name, string grade);

        List<Student> DeleteStudent(string name);
    }
