using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;

namespace Reg_App.Models
{
      public class Student:Person
    {
        public string RegNo {get; set;}
      
         public Courses Courses{get; set;}

         public Courses1 Courses1{get; set;}
       


   
        
         public Student(int id, string firstName, string lastName, string email, Gender gender, DateTime dateOfBirth, string address, string phoneNumber, string password, string nextofkin, Courses courses, Courses1 courses1): base( id,  firstName,  lastName,  email,  gender, dateOfBirth,  address,  phoneNumber,  password,  nextofkin)

       {
           RegNo = $"GC{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";   
           Courses = courses;
           Courses1 = courses1;
       }
       public string FullName()
       {
          return $"{FirstName} {LastName}";
       }    
    }
}