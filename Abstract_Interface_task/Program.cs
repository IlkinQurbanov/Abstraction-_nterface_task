using Abstract_Interface_task;


static void Main(string[] args)
{
    string userName = Console.ReadLine();
    string password = Console.ReadLine();

    User user = new User(userName, password);

    Console.WriteLine("Istifadecinin adi: {0}", user.UserName);
    Console.WriteLine("Parol: {0}", user.Password);

    bool hasDigit = user.HasDigit(password);
    Console.WriteLine("Parol reqemlerden ibaret: {0}", hasDigit);

    bool hasUpper = user.HasUpper(password);
    Console.WriteLine("Parol böyük hərfdən ibarətdir: {0}", hasUpper);

    bool hasLower = user.HasLower(password);
    Console.WriteLine("Parol kiçik hərfdən ibarətdir: {0}", hasLower);
}