using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;

namespace Reg_App.Models
{
      public class Grade
    {
        

        public int Jamb{get; set;}
        public string English {get; set;}
        public string Mathematics{get; set;}
        public string Physics {get; set;}
        public string Chemistry{get; set;}
        public string Biology{get; set;}
        public string AdditionalMathematics {get; set;}
        public string TechnicalDrawing {get; set;}
        public string Agriculture {get; set;}
        public string CivicEducation {get; set;}
        public double Total {get; set;}
       
        public Grade(int jamb, string english, string mathematics, string physics, string chemistry, string biology, string additionalMathematics, string technicalDrawing, string agriculture, string civicEducation, double total)
        {
            Jamb = jamb;
            English = english;
            Mathematics = mathematics;
            Physics = physics;
            Chemistry = chemistry;
            Biology = biology;
            AdditionalMathematics = additionalMathematics;
            TechnicalDrawing = technicalDrawing;
            Agriculture = agriculture;
            CivicEducation = civicEducation;
            Total = total;
            
           
            
        }

    }
}    