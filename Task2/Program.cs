namespace Task2
{
    internal class Program
    {
        private static string _login;
        private static string _password;
        static void Main(string[] args)
        {
            User user1 = new User();
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Confirm password: ");
            string confirm = Console.ReadLine();

            if (user1.IsCorrectUserData(login, password, confirm))
            {
                Console.WriteLine($"{login} registrated!");
                user1.Login = _login;
                user1.Password = _password;
            }
        }
    }
}
