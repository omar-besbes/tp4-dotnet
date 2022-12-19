using Microsoft.EntityFrameworkCore;
using tp4_dotnet.Models;

namespace tp4_dotnet.Data;

public interface IUniversityRepository
{
    public IEnumerable<Student> GetStudents();
    public IEnumerable<Student> GetStudentsByCourse(string course);
    public Student GetStudentById(int id);
    public void AddStudent(Student student);
    public void DeleteStudent(int studentId);
    public void UpdateStudent(Student student);
    public void Save();
    public void Dispose();
}

public class UniversityRepository : IUniversityRepository
{
    private UniversityContext? _context;

    public UniversityRepository(UniversityContext? context)
    {
        this._context = context;
    }

    public IEnumerable<Student> GetStudents()
    {
        return _context.Students.ToList();
    }

    public IEnumerable<Student> GetStudentsByCourse(string course)
    {
        return _context.Students.ToList().FindAll(student => student.Course == course);
    }

    public Student GetStudentById(int id)
    {
        return _context.Students.Find(id);
    }

    public void AddStudent(Student student)
    {
        _context.Students.Add(student);
    }

    public void DeleteStudent(int studentId)
    {
        var student = _context.Students.Find(studentId);
        _context.Students.Remove(student);
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