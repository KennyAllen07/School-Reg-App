using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;
using Reg_App.Models;

namespace Reg_App.Repo
{
    public class GradeRepo
    {       
        public static int myIndex = 0;
        private static int count = 1;

        public static int Jamb1{get; set;}
        public static string English1 {get; set;}
        public static string Mathematics1{get; set;}
        public static string Physics1 {get; set;}
        public static string Chemistry1{get; set;}
        public static string Biology1{get; set;}
        public static string AdditionalMathematics1 {get; set;}
        public static string TechnicalDrawing1 {get; set;}
        public static string Agriculture1 {get; set;}
        public static string CivicEducation1 {get; set;}
        public static double Total1 {get; set;}
      
        public static Grade[] grades =  new Grade[1500];
        
        public void Register(int jamb, string english, string mathematics, string physics, string chemistry, string biology, string additionalMathematics, string technicalDrawing, string agriculture, string civicEducation, double total)
        {
            Jamb1 = jamb;
            English1 = english;
            Mathematics1 = mathematics;
            Physics1 = physics;
            Chemistry1 = chemistry;
            Biology1 = biology;
            AdditionalMathematics1 = additionalMathematics;
            TechnicalDrawing1 = technicalDrawing;
            Agriculture1 = agriculture;
            CivicEducation1 = civicEducation;
            Total1 = total;
            var grade = new Grade (jamb, english, mathematics, physics, chemistry, biology, additionalMathematics, technicalDrawing, agriculture, civicEducation, total);
            grades[myIndex] = grade;
            Console.WriteLine($"Grades added successfully. Your total is {total}");
           
            count++;
            myIndex++;
            
        }

        public void PrintGrades()
        {
            Console.WriteLine("///////////////");
            Console.WriteLine($"Jamb: {Jamb1}");
            Console.WriteLine($"English: {English1}");
            Console.WriteLine($"Mathematics: {Mathematics1}");
            Console.WriteLine($"Physics: {Physics1}");
            Console.WriteLine($"Chemistry: {Chemistry1}");
            Console.WriteLine($"Biology: {Biology1}");
            Console.WriteLine($"Additional Mathematics: {AdditionalMathematics1}");
            Console.WriteLine($"Technical Drawing: {TechnicalDrawing1}");
            Console.WriteLine($"Agriculture: {Agriculture1}");
            Console.WriteLine($"Civic Education: {CivicEducation1}");
            Console.WriteLine("///////////////");
        }

        
    }

}
