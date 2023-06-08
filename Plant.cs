namespace Ripka;

class Plant
{
    public string Name { get; set; }
    public void AddWeight(ref int plantWeight)
    {
        var rand = new Random();

        int addedWeight = rand.Next(1,5);
        plantWeight += addedWeight;

        Console.WriteLine($"Вага ріпки збільшилась на {addedWeight} кг. Тепер вага ріпки становить {plantWeight} кг");
    }
    public Plant(string name)
    {
        Name = name;
    }
}