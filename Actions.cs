namespace Ripka;

class Actions
{
    Random rand = new Random();
    public Character[] characters = { new Character("Дідусь", 1), new Character("Бабуся", 2), new Character("Син", 1), new Character("Донька", 4),
                                      new Character("Внук", 3), new Character("Онучка", 2), new Character("Пес", 7), new Character("Кіт", 3),
                                      new Character("Миша", 1) };
    public void StrongToPullPlant(int plantWeight, int charactersStrength, ref bool isPulledUp)
    {
        if(plantWeight > charactersStrength)
        {
            isPulledUp = false;
        }
        else
        {
            isPulledUp = true;
        }
    }
    public int SummedUpStrengths(Character[] characters)
    {
        int charactersStrength = 0;
        for(int i = 0; i < characters.Length; i++)
        {
            if (characters[i] == null)
            {
                break;
            }
            else
            {
                charactersStrength += characters[i].Strength;
            }
        }
        return charactersStrength;
    }
}