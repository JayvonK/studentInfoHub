using studentInfoHub.Data;
using studentInfoHub.Models;

namespace studentInfoHub.Services.StudentServ;

public class StudentService : IStudentService
{
    private readonly DataContext _db;

    public StudentService(DataContext db)
    {
        _db = db;
    }
    public List<Student> AddStudent(string name, string grade)
    {
        Student newStudent = new();
        newStudent.Name = name;
        newStudent.Grade = grade;

        _db.Students.Add(newStudent);

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string name)
    {
        throw new NotImplementedException();
    }

    public List<Student> GetStudents()
    {
        throw new NotImplementedException();
    }

    public List<Student> SearchStudent(string name)
    {
        throw new NotImplementedException();
    }

    public List<Student> UpdateStudent(string name, string grade)
    {
        throw new NotImplementedException();
    }
}
