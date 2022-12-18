using System.ComponentModel.DataAnnotations;

namespace tp4_dotnet.Models;

public class Student
{
    private static int _nextId = 0;
    
    [Key] private int _id;
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string University { get; set; }
    public string Timestamp { get; set; }
    public Course Course { get; set; }

    public Student(string firstName, string lastName, string phoneNumber, string university, string timestamp, Course course)
    {
        _id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        University = university;
        Timestamp = timestamp;
        Course = course;
    }
}