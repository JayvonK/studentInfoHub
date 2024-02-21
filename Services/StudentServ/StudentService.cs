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

        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string name)
    {
        var found = _db.Students.FirstOrDefault(student => student.Name == name);
        if(found != null){
            _db.Remove(found);
            _db.SaveChanges();
        }

        return _db.Students.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.Students.ToList();
    }

    public List<Student> SearchStudent(string name)
    {
        return _db.Students.ToList();
    }

    public List<Student> UpdateStudent(string studentName, string name, string grade)
    {
        var found = _db.Students.FirstOrDefault(student => student.Name == studentName);
        if(found != null){
            found.Name = name;
            found.Grade = grade;
            _db.SaveChanges();
        }

        return _db.Students.ToList();
    }

    public List<Student> UpdateStudent(string name, string grade)
    {
        throw new NotImplementedException();
    }
}
