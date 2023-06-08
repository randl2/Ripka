namespace Ripka;

class FairyTale
{
    public void Start()
    {
        Actions actions = new Actions();
        Plant plant = new Plant("Ріпка");

        int plantWeight = 3;
        bool isPulledUp = false;
        Character[] charactersTogether = new Character[actions.characters.Length];
        Console.WriteLine("Казка Ріпка\nРосте собі ріпка...");

        int length = actions.characters.Length;
        for(int i = 0; i < length; i++)
        {
            charactersTogether[i] = actions.characters[i];

            string name = actions.characters[i].Name;
            int strength = actions.SummedUpStrengths(charactersTogether);

            Console.WriteLine($"Підходить {name}. І намагається вирвати, але...");
            actions.StrongToPullPlant(plantWeight, strength, ref isPulledUp);

            if(isPulledUp)
            {
                Console.WriteLine("Вітаю! ");
                if (charactersTogether[1] == null)
                {
                    Console.WriteLine($"{actions.characters[0].Name} витягнув ріпку!");
                }
                else if (charactersTogether[2] == null)
                {
                    Console.WriteLine($"{charactersTogether[0].Name} і {charactersTogether[1].Name} витягнули ріпку");
                }
                else
                {
                    for (int j = 0; j < charactersTogether.Length; j++)
                    {
                        if (charactersTogether[j] != null)
                        {
                            Console.Write($"{charactersTogether[j].Name}, ");
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write("\b\b");
                    Console.Write(" витягнули ріпку");
                }
                break;
            }
            else
            {
                Console.WriteLine("Не вийшло витягнути ріпку. Вона ще виросла!");
                plant.AddWeight(ref plantWeight);
            }
        }
        if (!isPulledUp)
        {
            Console.WriteLine("На жаль, більше немає кого покликати...");
        }
    }
}
