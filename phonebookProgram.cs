using System;
using System.Collection.Generic;
using System.Linq;
using System.Numeric;

class Student
{
  public string StudentNumber { get; set;}
  public string Surname { get; set;}
  public string FirstName { get; set;}
  public string Occupation {  get; set;}
  public string Gender { get; set;}
  public int CountryCode { get; set;}
  public string AreaCode { get; set;}
  public string PhoneNumber { get; set;}

   public Student(string studentNumber, string surname,
        string firstName, string occupation, string gender,
        int countryCode, string areaCode, string phoneNumber)
    {
        StudentNumber = studentNumber;
        Surname = surname;
        FirstName = firstName;
        Occupation = occupation;
        Gender = gender;
        CountryCode = countryCode;
        AreaCode = areaCode;
        PhoneNumber = phoneNumber;
    }

    public void Display()
    {
      Console.WriteLine(
        $"{Surname}, {Firstname}, with student number" +
          $"{StudentNumber}, is a {Occupation}. " +
            $"His/Her phone number is {CountryCode}-" +
            $"{AreaCode}-{PhoneNumber}");
    }
}

class ASEANPhonebook
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
   public Student FindStudent(string studentNumber)
    {
        return students.FirstOrDefault(
            s => s.StudentNumber == studentNumber);
    }
  
    public bool StudentNumberExists(string studentNumber)
    {
        return students.Any(
            s => s.StudentNumber == studentNumber);
    }
   public List<Student> SearchByCountry(HashSet<int> countryCodes)
    {
        return students
            .Where(s => countryCodes.Contains(s.CountryCode))
            .OrderBy(s => s.Surname)
            .ToList();
    }

    public List<Student> GetAllStudents()
    {
        return students
            .OrderBy(s => s.Surname)
            .ToList();
    }
}


  
