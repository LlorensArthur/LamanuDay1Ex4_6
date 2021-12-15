foreach (var item in Enum.GetNames(typeof(Days)))
{
    System.Console.WriteLine(item);
}
Days a = (Days)4;
Console.WriteLine(a);
enum Days{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
};

