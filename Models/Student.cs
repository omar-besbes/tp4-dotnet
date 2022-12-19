using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tp4_dotnet.Models;

[Table("Student")]
public class Student
{
    private static int _nextId = 0;

    [Key] 
    public int Id { get; set; }
    [Column("first_name")]
    public string FirstName { get; set; }
    [Column("last_name")]
    public string LastName { get; set; }
    [Column("phone_number")]
    public string PhoneNumber { get; set; }
    [Column("university")]
    public string University { get; set; }
    [Column("timestamp")]
    public string Timestamp { get; set; }
    [Column("course")]
    public string Course { get; set; }

    public Student(string firstName, string lastName, string phoneNumber, string university, string timestamp,
        string course)
    {
        Id = _nextId++;
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        University = university;
        Timestamp = timestamp;
        Course = course;
    }
}