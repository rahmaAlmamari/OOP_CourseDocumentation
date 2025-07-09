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
        private double Balance = 100;

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
           
        }
        public void ViewUserDetails(string password)
        {
            //to check if the user is valid or not ...
            if(password == Password)
            {
                //to display the values of the user object
                Console.WriteLine("User Details:");
                Console.WriteLine("User Name: " + UserName);
                Console.WriteLine("Email: " + Password);
                Console.WriteLine("Password: " + Email);
                Console.WriteLine("Balance:" + Balance);
            }
            else
            {
                Console.WriteLine("Invalid user");
            }
            
        }


    }
}
