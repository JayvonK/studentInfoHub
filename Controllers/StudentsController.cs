using Microsoft.AspNetCore.Mvc;
using studentInfoHub.Models;
using studentInfoHub.Services.StudentServ;

namespace studentInfoHub.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route("GetAllStudents")]
    public List<Student> GetStudents(){
        return _studentService.GetStudents();
    }

    [HttpGet]
    [Route("GetStudent/{studentName}")]
    public Student SearchStudent(string studentName){
        return _studentService.SearchStudent(studentName);
    }

    [HttpDelete]
    [Route("DeleteStudent/{studentName}")]
    public List<Student> DeleteStudent(string studentName){
        return _studentService.DeleteStudent(studentName);
    }

    [HttpPut]
    [Route("UpdateStudent/StudentName/{studentName}/UpdateName/{name}/UpdateGrade/{studentGrade}")]
    public List<Student> UpdateStudent(string studentName, string name, string studentGrade){
        return _studentService.UpdateStudent(studentName, name, studentGrade);
    }

    [HttpPost]
    [Route("AddStudent/StudentName/{studentName}/studentGrade/{studentGrade}")]
    public List<Student> AddStudent(string studentName, string studentGrade){
        return _studentService.AddStudent(studentName, studentGrade);
    }
}
