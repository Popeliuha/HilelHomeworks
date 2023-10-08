// See https://aka.ms/new-console-template for more information

using ClassLibrary1;
using ConsoleApp1;

#region taskFlower
Lavender lavender = new Lavender();
Flower lavender2 = new Lavender();

Console.WriteLine(lavender.GetDescription());
Console.WriteLine(lavender.Bloom());
Console.WriteLine();

Console.WriteLine(lavender2.GetDescription());
Console.WriteLine(lavender2.Bloom());
Console.WriteLine();

FlowerManager<Lavender> flower = new FlowerManager<Lavender>();
string info = flower.GetFullFlowerInfo(lavender);
Console.WriteLine(info);
#endregion

#region taskUser
//Console.WriteLine("Enter name");
//string name = Console.ReadLine() as string;

//Console.WriteLine("Enter last name");
//string surname = Console.ReadLine();

//Console.WriteLine("Enter gender");
//string gender = Console.ReadLine();
//Gender finalGen = ParseGender(gender);
//int age = 20;

//User user1 = new User(age)
//{
//    FirstName = name,
//    LastName = surname,
//    Gender = finalGen,
//};

//Console.WriteLine(user1.ToString());

//static Gender ParseGender(string gender)
//{
//    try
//    {
//        return Enum.Parse<Gender>(gender);
//    }
//    catch
//    {
//        return Gender.NotMentioned;
//    }
//}
#endregion