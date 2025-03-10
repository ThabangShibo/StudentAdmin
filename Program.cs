using System;

namespace StudentAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            //Control flow of the app
            StandardMessages.WelcomeMessage();

            Student student = StudentDataCapture.Capture();

            bool IsStudentDataValid = StudentDataValidator.Validate(student);

            if (IsStudentDataValid == false)
            {
                StandardMessages.CloseApplication();
            }

            AccountGenerator.CreateAccount(student);

            StandardMessages.CloseApplication();

        }
    }
}
