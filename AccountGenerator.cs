using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    public class AccountGenerator
    {
        public static void CreateAccount(Student student)
        {
            //Creating a username for the student
            Console.WriteLine($"Your username is {student.FirstName.Substring(0, 1).ToUpper()}{student.LastName}");
        }
        
    }
}
