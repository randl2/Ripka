namespace Ripka;

class Character
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public Character(string name, int strength)
    {
        Name = name;
        Strength = strength;
    }
    public Character() { }
}
