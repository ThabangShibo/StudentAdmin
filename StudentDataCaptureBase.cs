using System;

namespace StudentAdmin
{
    public class StudentDataCaptureBase
    {
        public static Student Capture()
        {
            //Ask for student information
            Student student = new Student();

            Console.Write("What is your first name: ");
            student.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            student.LastName = Console.ReadLine();

            return student;
        }
    }
}