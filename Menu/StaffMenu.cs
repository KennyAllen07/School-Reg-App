using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;
using Reg_App.Models;
using Reg_App.Repo;
namespace Reg_App.Menus
{
    public class StaffMenu
    {

        StaffRepo staffRepo = new StaffRepo();
        StudentRepo studentRepo = new StudentRepo();
        public void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter 1 To Login");
                Console.WriteLine("Enter 0 To Exit");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                    Login();
                    break;
                    case 0:
                    exit = true;
                    break;
                    default:
                    break;
                        
                }
            }
        }
        public void ManagerMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter 1 To Add New Staff");
                Console.WriteLine("Enter 2 To Get Staff");
                Console.WriteLine("Enter 3 To Get All Students");
                Console.WriteLine("Enter 4 To Get Specific Student Result");
                Console.WriteLine("Enter 5 To Get All Students Results");
                Console.WriteLine("Enter 0 To Go Back");
                
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        AddNewStaff();
                        break;
                    case 2:
                        staffRepo.PrintStaff();
                        break;
                    case 3:
                        studentRepo.GetStudentStaff();
                        break;
                    case 4:
                        GetSpecStudent();
                        break;

                    case 5:
                        studentRepo.GetAllStudentResult();
                        break;
                    case 0:

                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
         public void StaffsMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Enter 1 To Add New Staff");
                Console.WriteLine("Enter 2 To Get Staff");
                Console.WriteLine("Enter 0 To Go Back");
                
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        AddNewStaff();
                        break;
                    case 2:
                        staffRepo.PrintStaff();
                        break;
                    case 0:

                        exit = true;
                        break;
                    default:
                        break;
                }
            }
        }
        public void Login()
        {
            Console.WriteLine("Enter Your Email Address: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Password: ");
            string password = Console.ReadLine();
            var staff = staffRepo.Login(email, password);
            if(staff != null && staff.Role == Role.MainAdmin)
            {
                ManagerMenu();
            }
            else if(staff != null && staff.Role == Role.Admin)
            {
                StaffsMenu();
            }
          
            else
            {
                Console.WriteLine("Invalid email or password\n Enter any key to continue: ");
                Login();
            }
        }
        public void AddNewStaff()
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Gender: 1 Male \t2 Female \t3 Rather Not Say");
            int gender;
            while (!int.TryParse(Console.ReadLine(), out gender) && gender > 3 || gender < 1)
            {
                Console.WriteLine("Invalid Input Enter 1, 2 or 3");
            }
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
           
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter next Of Kin");
            string nextOfKin = Console.ReadLine();
            Console.WriteLine("Enter Date Of Birth(YYYY-MM-DD)");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Role");
            int role;
            while (!int.TryParse(Console.ReadLine(), out role) && role > 3 || role < 1)
            {
                Console.WriteLine("Invalid Input Enter 1, 2 or 3");
            }

            staffRepo.AddNewStaff(firstName, lastName, email, (Gender)gender, date, password, address, phoneNumber, nextOfKin, (Role)role);
        }

        public void GetSpecStudent()
        {
            Console.WriteLine("Enter the student's Registration Number: ");
            string regNo = Console.ReadLine();
            studentRepo.GetStudentResultStaff(regNo);
        }

         public void GetStaff()
        {
             Console.WriteLine("Enter Id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Gender: 1 Male \t2 Female \t3 Rather Not Say");
            int gender;
            while (!int.TryParse(Console.ReadLine(), out gender) && gender > 3 || gender < 1)
            {
                Console.WriteLine("Invalid Input Enter 1, 2 or 3");
            }
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter next Of Kin");
            string nextOfKin = Console.ReadLine();
            Console.WriteLine("Enter Date Of Birth");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Role");
            int role;
            while (!int.TryParse(Console.ReadLine(), out role) && role > 3 || role < 1)
            {
                Console.WriteLine("Invalid Input Enter 1, 2 or 3");
            }

            staffRepo.GetStaff(email);
        }
         public void HookScreen()
        {
            Console.WriteLine("Invalid Entry\n Enter any key to continue:");
            Console.ReadKey();
        }
    }

}



