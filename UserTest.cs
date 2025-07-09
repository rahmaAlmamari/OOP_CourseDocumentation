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

        //UserTest Class Methods ...
        //to create new user ...
        public void CreateUser(string userName,string email,string password)
        {
            UserName = userName;
            Email = email;
            Password = password;
            UserCount++;
            Console.WriteLine("User created successfully!");
            //to display the values of the user object
            Console.WriteLine("User Details:");
            Console.WriteLine("User Name: " + userName);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Password: " + password);
        }


    }
}
