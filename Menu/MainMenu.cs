using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Repo;
using Reg_App.Enums;
using Reg_App.Models;
namespace Reg_App.Menus{
    public class MainMenu{
        StudentRepo studentRepo = new StudentRepo();
        StudentMenu studentMenu = new StudentMenu();
        StaffRepo staffRepo = new StaffRepo();
        StaffMenu staffMenu = new StaffMenu();
        GradeRepo gradeRepo = new GradeRepo();
        GradeMenu gradeMenu = new GradeMenu();

        public void Menu(){
            bool exit = false;
            while (!exit)
            {
                PrintMenu();
                int op = int.Parse(Console.ReadLine());
                switch (op){
                    case 1:
                        studentMenu.Menu();
                        break;
                  
                    case 2:
                        staffMenu.Menu();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        HookScreen();
                        break;
                }
            }
        }

        private void PrintMenu(){
            Console.WriteLine("**************SCHOOL**************");
            Console.WriteLine("***************REG***************");
            Console.WriteLine("**************PORTAL**************");
            Console.WriteLine("Enter 1 To For (Student)");
            Console.WriteLine("Enter 2 To For (Staff)");
            Console.WriteLine("Enter 0 To Exit");
        }
        public void HookScreen(){
        Console.WriteLine($"Invalid input \n Enter any key to continue");
        Console.ReadKey();
        }

    }
}
