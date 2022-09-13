Console.WriteLine("Введите имя пользователя: ");
string name = Console.ReadLine();
if (name.ToLower() == "Маша")
{
    Console.WriteLine("Ура!!! Это жe Маша");
}
else
{
    Console.WriteLine("Привет");
    Console.WriteLine(name);
}
