using Microsoft.EntityFrameworkCore;
using tp4_dotnet.Models;

namespace tp4_dotnet.Data;

public class UniversityRepository
{
    private UniversityContext _context;

    public UniversityRepository(UniversityContext context)
    {
        this._context = context;
    }

    public IEnumerable<Student> GetStudents()
    {
        return _context.Student.ToList();
    }

    public Student GetStudentById(int id)
    {
        return _context.Student.Find(id);
    }

    public void AddStudent(Student student)
    {
        _context.Student.Add(student);
    }

    public void DeleteStudent(int studentId)
    {
        var student = _context.Student.Find(studentId);
        _context.Student.Remove(student);
    }

    public void UpdateStudent(Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}