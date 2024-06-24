namespace Task1
{
    internal class Program
    {
        private string _login;
        private string _password;

        public static bool IsCorrectUserData(string? login, string? password, string? confirm)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirm;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Confirm password: ");
            string confirm = Console.ReadLine();

            if (IsCorrectUserData(login, password, confirm))
                Console.WriteLine($"{login} registrated");
            else
                Console.WriteLine("Not registrated");
        }
    }
}
