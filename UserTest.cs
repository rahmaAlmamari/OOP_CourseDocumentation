using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CourseDocumentation
{
    //This is a test a class ...
    class UserTest
    {
        //Normal class members
        public string UserName;
        public string Password;
        public string Email;
        private double Balance;

        //Static class members
        public static int UserCount = 0;


        //Create an instance of the UserTest class
        UserTest user = new UserTest(); 

        //UserTest Class Methods ...
        //to create new user ...
        public void CreateUser()
        {

            //to get the values of the user object from the user input
            string userName;
            string email;
            string password;

            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();
            Console.Write("Enter Email: ");
            user.Email = Console.ReadLine();
            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();
            UserCount++;
            Console.WriteLine("User created successfully!");
        }


    }
}
