// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using Reg_App.Enums;
// using Reg_App.Models;

// namespace Reg_App.Repo
// {
//     public class StudentRepo
//     {
//         GradeRepo gradeRepo = new GradeRepo();
//          public static int myIndex = 0;
//         private static int count = 1;
//         public static Grade[] grades =  new Grade[100];
        
//         public void Register1(int jamb, string english, string mathematics, string physics, string chemistry, string biology, string additionalMathematics, string technicalDrawing, string agriculture, string civicEducation, double total)
//         {
//             var grade = new Grade (jamb, english, mathematics, physics, chemistry, biology, additionalMathematics, technicalDrawing, agriculture, civicEducation, total);
//             grades[myIndex] = grade;
           
//             count++;
//             myIndex++;
            
//         }
//         public static Student[] students = new Student[100];       
//         public void Register(string firstName, string lastName, string email, Gender gender, DateTime dateOfBirth,  string address, string phoneNumber, string password, string nextofkin, Courses courses, Courses1 courses1)
//         {
//             var student = new Student (count, firstName, lastName, email, gender, dateOfBirth, address, phoneNumber, password, nextofkin, courses, courses1);
//             students[myIndex] = student;
//             Console.WriteLine($"You have successfully created an account and your registration number is {student.RegNo}");
//             count++;
//             myIndex++;
            
//         }
//            public Student Login(string email, string password)
//         {
//             var student = GetStudent(email);
//             if(student != null && student.Password == password) 
//             {
//                 return student;
//             }    
//             return null;
         
//         }
//              public Student Result(string regNo, string password)
//         {
//             var student = GetStudentResult(regNo);
//             if(student != null && student.Password == password) 
//             {
//                 return student;
//             }    
//             return null;
         
//         }
//         public Student GetStudent(string email)
//         {
//             for (int i = 0; i < myIndex; i++)
//             {
//                 if (students[i] != null && students[i].Email == email)
//                 {
//                     return students[i];
//                 }
//             }
//             return null;
//         }
//          public Student GetStudentResult(string regNo)
//         {
//             for (int i = 0; i < myIndex; i++)
//             {
//                 for (int j = 0; j < myIndex; j++)
//                 {
//                      if (students[i] != null && grades[j] != null &&students[i].RegNo == regNo )
//                 {   Console.Write(i);
//                     Console.WriteLine(students[i].FirstName);
//                     Console.WriteLine(students[i].LastName);
//                     Console.WriteLine(students[i].RegNo);
//                     Console.WriteLine(students[i].Gender);
//                     Console.WriteLine(students[i].Email);
//                     Console.WriteLine(students[i].PhoneNumber);
//                     Console.WriteLine(students[i].Courses);
//                     Console.WriteLine(students[i].Courses1);
//                     Console.WriteLine(grades[j].Jamb);
//                     Console.WriteLine(grades[j].English);
//                     Console.WriteLine(grades[j].Mathematics);
//                     Console.WriteLine(grades[j].Physics);
//                     Console.WriteLine(grades[j].Chemistry);
//                     Console.WriteLine(grades[j].Biology);
//                     Console.WriteLine(grades[j].AdditionalMathematics);
//                     Console.WriteLine(grades[j].TechnicalDrawing);  
//                     Console.WriteLine(grades[j].Agriculture);
//                     Console.WriteLine(grades[j].CivicEducation);
//                     Console.WriteLine(grades[i].CivicEducation);
//                     Console.WriteLine(grades[j].Total);
//                 }
//                 }
               
//             }
//             return null;
//         }
//          public Student GetStudentStaff()
//         {
//             for (int i = 0; i < myIndex; i++)
//             {
//                 if (students[i] != null)
//                 {
//                     return students[i];
//                 }
//             }
//             return null;
//         }
//          public Student GetStudentResultStaff(string regNo)
//         {
//             for (int i = 0; i < myIndex; i++)
//             {
//                 for (int j = 0; j < myIndex; j++)
//                 {
//                      if (students[i] != null && grades[j] != null &&students[i].RegNo == regNo )
//                 {   Console.Write(i);
//                     Console.WriteLine(students[i].FirstName);
//                     Console.WriteLine(students[i].LastName);
//                     Console.WriteLine(students[i].RegNo);
//                     Console.WriteLine(students[i].Gender);
//                     Console.WriteLine(students[i].Email);
//                     Console.WriteLine(students[i].PhoneNumber);
//                     Console.WriteLine(students[i].Courses);
//                     Console.WriteLine(students[i].Courses1);
//                     Console.WriteLine(grades[j].Jamb);
//                     Console.WriteLine(grades[j].English);
//                     Console.WriteLine(grades[j].Mathematics);
//                     Console.WriteLine(grades[j].Physics);
//                     Console.WriteLine(grades[j].Chemistry);
//                     Console.WriteLine(grades[j].Biology);
//                     Console.WriteLine(grades[j].AdditionalMathematics);
//                     Console.WriteLine(grades[j].TechnicalDrawing);  
//                     Console.WriteLine(grades[j].Agriculture);
//                     Console.WriteLine(grades[j].CivicEducation);
//                     Console.WriteLine(grades[i].CivicEducation);
//                     Console.WriteLine(grades[j].Total);
//                 }
//                 }
               
//             }
//             return null;
//         }
//          public Student GetAllStudentResult()
//         {
//             for (int i = 0; i < students.Length; i++)
//             {
//                 for (int j = 0; j < grades.Length; j++)
//                 {
//                      if (students[i] != null && grades[j] != null)
//                 {
//                     Console.Write(i);
//                     Console.WriteLine(students[i].FirstName);
//                     Console.WriteLine(students[i].LastName);
//                     Console.WriteLine(students[i].RegNo);
//                     Console.WriteLine(students[i].Gender);
//                     Console.WriteLine(students[i].Email);
//                     Console.WriteLine(students[i].PhoneNumber);
//                     Console.WriteLine(students[i].Courses);
//                     Console.WriteLine(students[i].Courses1);
//                     Console.WriteLine(grades[j].Jamb);
//                     Console.WriteLine(grades[j].English);
//                     Console.WriteLine(grades[j].Mathematics);
//                     Console.WriteLine(grades[j].Physics);
//                     Console.WriteLine(grades[j].Chemistry);
//                     Console.WriteLine(grades[j].Biology);
//                     Console.WriteLine(grades[j].AdditionalMathematics);
//                     Console.WriteLine(grades[j].TechnicalDrawing);  
//                     Console.WriteLine(grades[j].Agriculture);
//                     Console.WriteLine(grades[j].CivicEducation);
//                     Console.WriteLine(grades[i].CivicEducation);
//                     Console.WriteLine($"{grades[j].Total} \n///////////");
                

//                 }
//                 }
               
//             }
//             return null;
//         }
//     }

// }
