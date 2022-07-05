using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;
using Reg_App.Models;
using Reg_App.Repo;
namespace Reg_App.Menus;
    public class GradeMenu
    {
        GradeRepo gradeRepo = new GradeRepo();
        StudentRepo studentRepo = new StudentRepo();
        
       
        public void GradesMenu()
        {
            bool cont = false;
            while (!cont)
            {
                PrintSubMenu();
                {
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            DetailsMenu();
                            break;
                        case 2:
                            CheckResult();
                            break;
                        case 0:
                           cont = true;
                            break;
                       
                    }

                }
            }
        }

        public void PrintSubMenu()
        {
            Console.WriteLine("Enter 1 To Fill in Details: ");
            Console.WriteLine("Enter 2 To Check Result: ");
            Console.WriteLine("Enter 0 To Go Back To The Main Menu: ");
        }

        public void PrintMenu()
        {
           
            Console.WriteLine("Enter 1 To Check Bio: ");
            
            Console.WriteLine("Enter 0 To Exit: ");

        }


        
        public void DetailsMenu()
       
           
        {
            Console.WriteLine("Enter your Jamb Score: ");
            int jamb;
            while (!int.TryParse(Console.ReadLine(), out jamb))
            {
                Console.WriteLine("Enter your Jamb Score: ");
            }
            int score = 0;
            Console.WriteLine("Enter your WAEC Grades in Capital Letters.");
            Console.WriteLine("Enter your grade in English: ");
            string english = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Mathematics: ");
            string mathematics = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Physics: ");
            string physics = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Chemistry: ");
            string chemistry = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Biology: ");
            string biology = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Additional Mathematics: ");
            string additionalMathematics = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Technical Drawing: ");
            string technicalDrawing = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Agriculture: ");
            string agriculture = $"{score += WaecScore(Console.ReadLine())}";
             Console.WriteLine("Enter your grade in Civic Education: ");
            string civicEducation = $"{score += WaecScore(Console.ReadLine())}";
            double JB = (jamb/400.0) * 50;
            double WC =  (score/45.0) * 50;
            double total = JB + WC;
           
            Console.WriteLine($"Your percentage total is {total}");
            
            static int WaecScore(string grade)
        {
            
            if(grade == "A")
            {
                return 5;
                
            }
            else if (grade == "B")
            {
                return 4;
            }
             else if (grade == "C")
            {
                return 3;
            }
             else if (grade == "D")
            {
                return 2;
            }
             else if (grade == "E")
            {
                return 1;
            }
             else if (grade == "F")
            {
                return 0;
            }
            return WaecScore(grade);
            //gradeRepo.Register()

            
        }
        gradeRepo.Register(jamb, english, mathematics, physics,chemistry,biology,additionalMathematics, technicalDrawing,agriculture,civicEducation,total);
        }

   
        public void CheckResult()
        {
            Console.WriteLine("Enter your Registration Number: ");
            string regNo = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();
             var student = studentRepo.Result(regNo, password);
            if (student != null)
            {
                gradeRepo.PrintGrades();
                 Console.WriteLine("Enter 1 to Go back to the Student Menu");
                Console.WriteLine("Enter 0 to Exit");
                 bool cont = false;
            while (!cont)
            {
                PrintSubMenu();
                {
                    int op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                           cont = true;
                            break; 
                        case 0:
                           cont = true;
                            break;
                        default:
                        HookScreen();
                        break;    
                       
                    }

                }
            }
        }
        }
        public void HookScreen()
        {
            Console.WriteLine("Invalid Entry\n Enter any key to continue:");
            Console.ReadKey();
        }
         public void HookScreen1()
        {
            Console.WriteLine("Enter any key to continue:");
            Console.ReadKey();
        }
    }
        
