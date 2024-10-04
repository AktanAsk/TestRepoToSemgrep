
// Проблема 1: Использование уязвимого метода для сравнения строк
string password = "password123";
string inputPassword = Console.ReadLine();
if (password == inputPassword) // Строковое сравнение уязвимо к тайминг-атакам
{
    Console.WriteLine("Доступ разрешен");
}
else
{
    Console.WriteLine("Неверный пароль");
}

// Проблема 2: Уязвимость SQL-инъекции
string userInput = Console.ReadLine();
string query = "SELECT * FROM Users WHERE username = '" + userInput + "'"; // Неподготовленный SQL-запрос

// Проблема 3: Неуправляемый тип для пароля
string apiKey = "API_KEY_12345"; // Строка не удаляется из памяти, что может стать уязвимостью

// Проблема 4: Потенциальная утечка информации
try
{
    int result = Divide(10, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Произошла ошибка: " + ex.Message); // Раскрытие детали ошибки пользователю
}

// Проблема 5: Неиспользуемая переменная
int unusedVariable = 10;

// Проблема 6: Переполнение целого числа
int maxValue = int.MaxValue;
int overflow = maxValue + 1; // Приведет к переполнению

// Проблема 7: Игнорирование возвращаемого значения
var collection = GetItems();
collection.Sort(); // Результат сортировки не сохраняется

// Проблема 8: Несовместимость типа
object obj = "строка";
int num = (int)obj; // Приведет к InvalidCastException во время выполнения
    

static int Divide(int a, int b)
{
    return a / b;
}

static List<int> GetItems()
{
    return new List<int> { 3, 1, 2 };
}
