namespace OOP_CourseDocumentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create an instance of the UserTest class
            UserTest user = new UserTest();

            //to show user menu options
            Console.WriteLine("Welcome to User Management System");
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. View User Details");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Deposit");
            Console.WriteLine("5. Exit");

            ////enter a value to user object fields which is a copye of UserTest class
            //user.UserName = "Rahma Almamari";
            //user.Email = "rahma.almamari@gmail.com";
            //user.Password = "12345678";

            //to get the values of the user object from the user input
            Console.Write("Enter User Name: ");
            user.UserName = Console.ReadLine();
            Console.Write("Enter Email: ");
            user.Email = Console.ReadLine();
            Console.Write("Enter Password: ");
            user.Password = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------");

            //to display the values of the user object
            Console.WriteLine("User Details:");
            Console.WriteLine("User Name: " + user.UserName);
            Console.WriteLine("Email: " + user.Email);
            Console.WriteLine("Password: " + user.Password);
        }
    }
}
