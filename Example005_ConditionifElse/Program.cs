Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "антоха")
{
    Console.WriteLine ("О, дарова Антоха, давно не видел тебя в уличных гонках");
}
else 
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}
