namespace CheckPasword
{
    public delegate void InformationCheck(string message);
    public delegate bool UserCheck(string login, string password);
    public class ProccessCheckPassword
    {
        public event InformationCheck Success;              // 1.Определение события
        public event InformationCheck Error;
        public ProccessCheckPassword() {}
        public bool CheckPassword(UserCheck userCheck, string login, string password)
        {
            bool resultCheck = userCheck(login, password);
            if (resultCheck)
            {
                Success?.Invoke($"Пользователь с логином: {login} авторизован. Вход разрешен");   // 2.Вызов события
            }
            else if (!resultCheck)
            {
                Error?.Invoke($"Ошибка логина {login} или пароляю Вход запрещен"); // 2.Вызов события
            }
            return resultCheck;
        }

    }
}