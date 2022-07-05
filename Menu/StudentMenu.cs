using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;
using Reg_App.Models;
using Reg_App.Repo;
using Reg_App.Menus;
namespace Reg_App.Menus
{
    public class StudentMenu
    {
        GradeMenu gradeMenu = new GradeMenu();
        GradeRepo gradeRepo = new GradeRepo();
        StudentRepo studentRepo = new StudentRepo();
       
        public void Menu()
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
                            RegistrationMenu();
                            break;
                        case 2:
                            Loginmenu();
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
            Console.WriteLine("Enter 1 To Register");
            Console.WriteLine("Enter 2 To Login");
            Console.WriteLine("Enter 0 To Go Back To The Main Menu: ");
        }

        public void PrintMenu()
        {
            
           
            Console.WriteLine("Enter 1 To Check Bio");
            Console.WriteLine("Enter 2 to fill in Details");
            Console.WriteLine("Enter 0 To Exit");

        }

        private void RegistrationMenu()
        {
            Console.WriteLine("Enter Your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Gender: 1 Male \t2 Female \t3 Rather Not Say");
            int gender;
            while (!int.TryParse(Console.ReadLine(), out gender) && gender > 3 || gender < 1)
            {
                Console.WriteLine("Invalid Input Enter 1, 2 or 3");
            }
            Console.WriteLine("Enter Your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
           
            Console.WriteLine("Enter Your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your next Of Kin");
            string nextOfKin = Console.ReadLine();
            Console.Write("Enter Your Date Of Birth in the format (YYYY-MM-DD");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Most Preffered Course: 1.Engineering \t2.Medicine \t3.Agriculture \t4.Statistics \t5.Physics \t6.Chemistry \t7.Biology \t8.BioChemistry \t9.Geology \t10.Physiology \t11.Anatomy \t12.Pharmacy \t13.AnimalScience \t14.Botany \t15.Zoology \t16.ComputerScience: ");
             int courses;
            while (!int.TryParse(Console.ReadLine(), out courses) && courses > 16 || courses < 1)
            {
                Console.WriteLine("Invalid Input Enter a number corresponding to the courses set above");
            }
            Console.WriteLine("Enter Your 2nd Most Preffered Course: 1.Engineering \t2.Medicine \t3.Agriculture \t4.Statistics \t5.Physics \t6.Chemistry \t7.Biology \t8.BioChemistry \t9.Geology \t10.Physiology \t11.Anatomy \t12.Pharmacy \t13.AnimalScience \t14.Botany \t15.Zoology \t16.ComputerScience: ");
            int courses1;
            while (!int.TryParse(Console.ReadLine(), out courses1) && courses1 > 16 || courses1 < 1)
            {
                Console.WriteLine("Invalid Input Enter a number corresponding to the courses set above");
            }
            

            studentRepo.Register(firstName, lastName, email, (Gender)gender, dateOfBirth, address, phoneNumber, password, nextOfKin, (Courses)courses, (Courses1)courses1);
        }

        

        private void Loginmenu()
        {
            Console.WriteLine("Enter Your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            var student = studentRepo.Login(email, password);
            if (student != null)
            {
                gradeMenu.GradesMenu();
            }
            else
            {
                Console.WriteLine("Invalid Email or password.");
                Loginmenu();
            }
        }
       
        
        
        public void HookScreen()
        {
            Console.WriteLine("Invalid Entry\n Enter any key to continue:");
            Console.ReadKey();
        }
        
        
    }
}