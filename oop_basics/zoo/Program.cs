using System.Globalization;

namespace zoo;

class Program
{
    static void Main(string[] args)
    {
        Cage[] cages = new Cage[4];
        for (int i = 0; i < cages.Length; i++)
        {
            cages[i] = new Cage(i+1);
        }

        cages[0].Add(new Animal("Bodri", true, 30, Species.Dog));
        cages[1].Add(new Animal("Csicska", true, 10, Species.Rabbit));
        cages[1].Add(new Animal("Lola", false, 25, Species.Dog));
        cages[2].Add(new Animal("Bamboo", true, 100, Species.Panda));
        cages[2].Add(new Animal("Ling", false, 90, Species.Panda));
        cages[2].Add(new Animal("Hopper", false, 8, Species.Rabbit));
        cages[3].Add(new Animal("Max", true, 35, Species.Dog));
        cages[3].Add(new Animal("Snowball", false, 12, Species.Rabbit));
        cages[3].Add(new Animal("BaoBao", true, 110, Species.Panda));
        cages[3].Add(new Animal("Mimi", false, 9, Species.Rabbit));
        

        for (int i = 0; i < cages[2].Allatok(Species.Panda).Count; i++)
        {
            Console.Write(cages[2].Allatok(Species.Panda)[i].GetName() + " ");
        }
        
        Console.WriteLine(cages[3].Average(Species.Rabbit));

        if (cages[3].SameSame())
        {
            Console.WriteLine("Igaz");
        }
        else
        {
            Console.WriteLine("Hamis");
        }

        int MaxNumber(Cage[] ketrecek, Species species)
        {
            int maxSpecies = 0;
            int maxIndex = 0;
        
            for (int i = 0; i < ketrecek.Length; i++)
            {
                if (cages[i].GetNumberOfSpecificSpecies(species) > maxSpecies)
                {
                    maxSpecies = cages[i].GetNumberOfSpecificSpecies(species);
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        
        Console.WriteLine(MaxNumber(cages, Species.Dog) + ". tömbben van a legtöbb kutya.");
        Console.WriteLine(MaxNumber(cages, Species.Panda) + ". tömbben van a legtöbb panda.");
        Console.WriteLine(MaxNumber(cages, Species.Rabbit) + ". tömbben van a legtöbb csicska.");
        cages[3].Print();
        
        //ToDo fájl és könyvtár beolvasás
        
        
    }
}