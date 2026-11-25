using System;
using System.Collection.Generic;
using System.Linq;
using System.Numeric;

// CLASS 1: STUDENT
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
// CLASS 2: ASEAN PHONEBOOK
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


// Class Country 3
class Country
{
    public static readonly Dictionary<int, string> Countries =
        new Dictionary<int, string>()
        {
            { 60, "Malaysia" },
            { 62, "Indonesia" },
            { 63, "Philippines" },
            { 65, "Singapore" },
            { 66, "Thailand" }
        };

    public static bool IsValidCountryCode(int code)
    {
        return Countries.ContainsKey(code);
    }

    public static string GetCountryName(int code)
    {
        return Countries.ContainsKey(code)
            ? Countries[code]
            : "Unknown";
    }
}

class Program
{
    static ASEANPhonebook phonebook = new ASEANPhonebook();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n===== ASEAN PHONEBOOK =====");
            Console.WriteLine("[1] Store to ASEAN phonebook");
            Console.WriteLine("[2] Edit entry in ASEAN phonebook");
            Console.WriteLine("[3] Search ASEAN phonebook by country");
            Console.WriteLine("[4] Exit");

            Console.Write("Enter choice: ");
            string choice = Console.ReadLine() ?? "";
          

  
