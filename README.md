# CheckPasword - система проверки и логирования результата проверки введенного логина и пароля пользователя
# API
Для работы с модулем используется класс `ProccessCheckPassword`

## Делегаты
- `InformationCheck(string message)` типа `void` - для логирования результатов проверки. Через него определяется события `event` с именем `Success` и `Error`, которые представляют делегат и передают результат проверки при подключении к логу;
- `UserCheck(string login, string password)` типа `bool` - для проверки введенного логина и пароля. Данный метод не проверяет правильность логина и пароля, а указывает на метод, разработанный пользователем. Сигнатура метода проверки логина и пароля пользователя должна соответствовать данному делегату.

## Метод
- `CheckPassword(UserCheck, login, password)` типа `bool` - метод принимает три параметра:
    - `UserCheck` - принимает делегат, который указывает на метод проверки логина и пароля пользователя. Результат данного метода возвращает либо `true`, либо `false`, в зависимости от результата метода проверки правильности логина и пароля пользователем;
    - `login` типа `string` - принимает введенный пользователем логин для проверки;
    -  `password` типа `string` - принимает введенный пользователем пароль для проверки;

Метод возвращает результат проверки введенного логина и пароля либо `true`, либо `false`

## Результат работы метода и текст событий
- `Success` - успешное завершение операции. В лог передается следующий текст - _Пользователь с логином: <логин пользователя> авторизован. Вход разрешен_;
- `Error` - неверные введенные данный. В лог передается следующий текст - _Ошибка логина <логин пользователя> или пароля. Вход запрещен_.
