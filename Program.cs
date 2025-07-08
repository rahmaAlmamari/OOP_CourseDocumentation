namespace OOP_CourseDocumentation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create an instance of the UserTest class
            UserTest user = new UserTest();

            //enter a value to user object fields which is a copye of UserTest class
            user.UserName = "Rahma Almamari";
            user.Email = "rahma.almamari@gmail.com";
            user.Password = "12345678";
        }
    }
}
