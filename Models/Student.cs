
namespace studentInfoHub.Models;
    public class Student
    {
        public int Id {get; set;}
        public string Name {get; set;} = "No Student";

        public string Grade {get; set;} = "N/A";

    internal List<Student> ToList()
    {
        throw new NotImplementedException();
    }
}