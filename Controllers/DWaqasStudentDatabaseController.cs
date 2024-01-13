// The Controller handles the requests and returns that happen when someone calls the Endpoint
// It calls the Interface to match it's Method to what the request is asking for, and returns the output
using DWaqasStudentDatabase.Models;
using DWaqasStudentDatabase.Services.CRUD;
using Microsoft.AspNetCore.Mvc;
 // Added with [ApiController]

namespace DWaqasStudentDatabase.Controllers;

[ApiController] // Telling dotnet to read this file as an Api Controller
[Route("[controller]")] // Removing the need to type controller to access this file

public class DWaqasStudentDatabaseController : ControllerBase
{
    private readonly ICrudService _CrudService; // A saved reference of our Interface

    public DWaqasStudentDatabaseController(ICrudService CrudService) // Constructor - runs first when the class is called
    // Injecting our Interface into our Controller named studentService
    {
        // Saving a reference to our Interface to a field named _studentService so when we call it, we can access it's Methods
        _CrudService = CrudService;
    }

    [HttpGet] // use Get to get/pull data
    [Route("FetchQuest")] // Route name does not have to match Method name, but Routes give a specific Address to each Method
    public List<Student> GetStudents()
    {
        // Accessing the GetStudents() from our Interface
        return _CrudService.GetStudents();
    }

    [HttpPost] // use Post to add Data
    [Route("AddStudent/{firstName}/{lastName}/{studentHobby}")] // To pass data through Routes add /{parameter name}
    public List<Student> AddStudent(string firstName, string lastName,  string studentHobby)
    {
        return _CrudService.AddStudent(firstName, lastName, studentHobby);
    }

    [HttpDelete] // use Delete to delete data - not really don't do this
    [Route("DeleteStudent/{firstName}")]
    public List<Student> DeleteStudent(string firstName)
    {
        return _CrudService.DeleteStudent(firstName);
    }
}
