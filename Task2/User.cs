namespace Task2
{
    internal class User
    {
        private string _login;
        private string _password;    

        public string Login { get => _login; set => _login = value; }
        public string Password { get => _password; set => _password = value; }

        public bool IsCorrectUserData(string? login, string? password, string? confirm)
        {
            bool isLoginCorrect = !string.IsNullOrEmpty(login);
            bool isPasswordCorrect = !string.IsNullOrEmpty(password);
            bool isConfirmCorrect = password == confirm;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
