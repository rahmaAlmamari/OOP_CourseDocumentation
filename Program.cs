namespace OOP_CourseDocumentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menu = "y"; // Initialize menu to true to enter the loop
            do
            {
                //to call Menu method ...
                Menu();
                Console.WriteLine("Do you want to do something more? (y/n)");
                menu = Console.ReadLine();

            } while (menu == "y" || menu == "Y");
   

            ////enter a value to user object fields which is a copye of UserTest class
            //user.UserName = "Rahma Almamari";
            //user.Email = "rahma.almamari@gmail.com";
            //user.Password = "12345678";

            //to get the values of the user object from the user input
            //Console.Write("Enter User Name: ");
            //user.UserName = Console.ReadLine();
            //Console.Write("Enter Email: ");
            //user.Email = Console.ReadLine();
            //Console.Write("Enter Password: ");
            //user.Password = Console.ReadLine();

            //Console.WriteLine("-----------------------------------------------");

            ////to display the values of the user object
            //Console.WriteLine("User Details:");
            //Console.WriteLine("User Name: " + user.UserName);
            //Console.WriteLine("Email: " + user.Email);
            //Console.WriteLine("Password: " + user.Password);
        }

        //Menu Method ...
        public static void Menu()
        {
            Console.Clear();
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

            char userChoice = '0'; // Initialize userChoice to avoid uninitialized variable warning
            userChoice = Console.ReadKey().KeyChar; // Read user input
            switch (userChoice)
            {
                case '1':
                    //Console.WriteLine("Creating User...");
                    // Code to create user
                    string userName, email, password;
                    Console.Write("Enter User Name: ");
                    userName = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    email = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    password = Console.ReadLine();
                    user.CreateUser(userName, email, password);
                    break;
                case '2':
                    //Console.WriteLine("Viewing User Details...");
                    // Code to view user details
                    break;
                case '3':
                    //Console.WriteLine("Checking Balance...");
                    // Code to check balance
                    break;
                case '4':
                    //Console.WriteLine("Depositing...");
                    // Code to deposit
                    break;
                case '5':
                    Console.WriteLine("Have a nice day (^0^)");

                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
