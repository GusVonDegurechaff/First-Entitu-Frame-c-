using ConsoleApp3.Classes;

using (ApplicationContext db = new ApplicationContext())
{
    Console.WriteLine("Введите кол-во добавляемых пользователей");
    int z = int.Parse(Console.ReadLine());
    List<User> users = new List<User>();
    for (int x = 0; x < z; x++ )
    {
        Console.WriteLine("Как зовут пользователя?");
        string Name = Console.ReadLine();
        Console.WriteLine("Возраст пользователя?");
        int Age = Convert.ToInt32(Console.ReadLine());

        User user = new User(Name, Age);

        users.Add(user);
    }

    
}
