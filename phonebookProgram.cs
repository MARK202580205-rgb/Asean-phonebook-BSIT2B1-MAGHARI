using System;
using System.Collection.Generic;
using System.Ling;
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

  
