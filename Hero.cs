public class Hero
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string Type {get; set;}

    public Hero (string name, int age, string type)
    {
        Name = name;
        Age = age;
        Type = type;
    }

    public void Attack()
    {
        string attack = "";

        switch (Type)
        {
            case "mage":
                attack = "uses magic";
                break;
            case "warrior":
                attack = "uses sword";
                break;
            case "monk":
                attack = "uses martial arts";
                break;
            case "ninja":
                attack = "uses shuriken";
                break;
            default:
                attack = "carried out an attack";
                break;
        }

        Console.WriteLine($"The {Type} attacked using  {attack}");
    }
}