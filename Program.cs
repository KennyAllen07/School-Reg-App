// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using Reg_App.Repo;
using Reg_App.Menus;


namespace Reg_App.Manage
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Menu();
            // StudentMenu studentMenu =  new StudentMenu();
            // studentMenu.Menu();
        // StaffMenu staffMenu = new StaffMenu();
        // staffMenu.Menu();
            

            
        }
    }
}
