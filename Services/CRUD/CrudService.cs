// The Service handles the logic
using DWaqasStudentDatabase.Data;
using DWaqasStudentDatabase.Models;


namespace DWaqasStudentDatabase.Services.CRUD;

// When we inherit from IStudentService, we have to follow the blueprint that it laid out, all of the Methods, their names, return types, and parameters
public class CrudService : ICrudService
{
    private readonly DataContext _db;

    public CrudService(DataContext db)
    {
        _db = db;
    }

    public List<Student> AddStudent(string firstName, string lastName, string studentHobby)
    {
       Student newStudent = new();
       newStudent.First = firstName;
       newStudent.Last = lastName;
      newStudent.Hobby = studentHobby;

       _db.CRUD.Add(newStudent);
       _db.SaveChanges();

       return _db.CRUD.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
      var foundStudent = _db.CRUD.FirstOrDefault(student => student.First == firstName);
      if(foundStudent != null){
        _db.CRUD.Remove(foundStudent);
        _db.SaveChanges();
      }
      return _db.CRUD.ToList();
    }

    public List<Student> GetStudents()
    {
        return _db.CRUD.ToList();
    }

}