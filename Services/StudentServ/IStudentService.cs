using studentInfoHub.Models;

namespace studentInfoHub.Services.StudentServ;

    public interface IStudentService
    {
        List<Student> GetStudents();

        string SearchStudent(string name);

        List<Student> AddStudent(string name, string grade);

        List<Student> UpdateStudent(string name, string grade);

        List<Student> DeleteStudent(string name);
    }
