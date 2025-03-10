using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmin
{
    public class StudentDataValidator
    {
        public static bool Validate(Student student)
        {
            //Validate the information
            if (string.IsNullOrEmpty(student.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");             
                return false;
            }

            if (string.IsNullOrEmpty(student.LastName))
            {
                StandardMessages.DisplayValidationError("last name");            
                return false;
            }

            return true;
        }
    }
}
