using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;
using Reg_App.Models;

namespace Reg_App.Repo
{
    public class StaffRepo
    {
        private static int count = 1;
        public static Staff[] staffs = new Staff[10];
        private static int myIndex = 1;


        public StaffRepo()
        {
            var staff =  new Staff(1,"Kehinde", "Makinde", "kehinde.makinde07@gmail.com", Gender.Male, DateTime.Parse("1982-11-13"),"COMSIT, University Of Ilorin, Ilorin", "08160375199","KennyAllen07", "I don't have.", Role.MainAdmin);
            staffs[0] = staff;
        }
        public void AddNewStaff(string fName, string lName, string email, Gender gender, DateTime dateOfBirth, string address, string phoneNumber, string password, string nextofkin, Role role)
        {
            int id = ++count;
            Staff staff = new Staff(id, fName, lName, email, gender, dateOfBirth, address, phoneNumber, password, nextofkin, role);
            staffs[count - 1] = staff;
            Console.WriteLine("New Staff was successfully added.");
            
          
         
        }
        public Staff Login( string email, string password)
        {
            var staff = GetStaff(email);
            if(staff != null && staff.Password == password) 
            {
                return staff;
            }    
            return null;
         
        }
      
        public Staff GetStaff(string email)
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                if (staffs[i] != null && staffs[i].Email == email)
                {
                    return staffs[i];
                }
            }
            return null;
        }
        public Staff PrintStaff()
        {
            for (int i = 0; i < staffs.Length; i++)
            {
                  if (staffs[i] != null)
                {
                Console.WriteLine($"{i}.{staffs[i].FirstName}, {staffs[i].LastName}, {staffs[i].PhoneNumber}, {staffs[i].Email}, {staffs[i].Password} ");
                }
            }
            return null;
        }
       
    }

}
