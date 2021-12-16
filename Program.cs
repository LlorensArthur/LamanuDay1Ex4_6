// Affichage de toutes les valeurs de l'enum
Console.WriteLine("Voici toutes les valeurs de l'enum week :");
foreach (var item in Enum.GetNames(typeof(week)))
{
    System.Console.WriteLine(item);
}
// Affichage de la valeur 4 de l'enum
week valueDay = (week)3;
Console.WriteLine($"Voici la valeur 4 de l'enum week{valueDay}");
enum week{
    Lundi,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
};

