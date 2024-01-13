using DWaqasStudentDatabase.Models;
namespace DWaqasStudentDatabase.Services.CRUD;

public interface ICrudService
{
    List<Student> GetStudents();
    List<Student> AddStudent(string firstName, string lastName, string studentHobby);
    List<Student> DeleteStudent(string firstName);
}