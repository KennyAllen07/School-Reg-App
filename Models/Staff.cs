using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reg_App.Enums;

namespace Reg_App.Models
{
    public class Staff:Person
    {
       public string StaffNo {get; set;}
       public Role Role {get; set;}
       public Staff(int id, string firstName, string lastName, string email, Gender gender, DateTime dateOfBirth, string address, string phoneNumber, string password, string nextofkin, Role role): 
       base( id,  firstName, lastName,  email,  gender, dateOfBirth,  address,  phoneNumber,  password,  nextofkin)

       {
           StaffNo = $"ADMIN{Guid.NewGuid().ToString().Replace("-", "").Substring(0, 5).ToUpper()}";
           Role = role;

       }
       

        // public static Staff ToStaff(string str)
        // {
        //     var myadmin = str.Split("\t");
        //     var firstname = myadmin[0];
        //     var lastname = myadmin[1];
        //     var email = myadmin[2];
        //     var password = myadmin[3];
        //     return new Staff(id, firstname, lastname, email, password);
        // }

    }
}