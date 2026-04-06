namespace zoo;

public class Cage
{
    private Animal[] animals;
    private int actualN = 0;
    
    public Cage (int n)
    {
        if (n <= 10)
        {
            this.animals = new Animal[n];
        }
    }

    public bool Add(Animal animal)
    {
        if (this.animals.Length > this.actualN)
        {
            this.animals[this.actualN] = animal;
            this.actualN++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Delete(string name)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i].GetName() == name)
            {
                for (int j = i; j < animals.Length-1; j++)
                {
                    animals[j] = animals[j+1];
                }
            }
        }
    }
    
    public int GetNumberOfSpecificSpecies(Species species)
    {
        int count = 0;
        for (int i = 0; i < animals.Length; i++)
        {
            if (animals[i].GetSpecies() == species)
            {
                count++;
            }
        }
        return count;
    }

    public bool Exists(Species species, bool sex)
    {
        int n = 0;
        for (int i = 0; i < this.animals.Length; i++)
        {
            if (animals[i].GetSpecies() == species && animals[i].GetSex() == sex)
            {
                n++;
            }
        }
        if (n > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public List<Animal> Allatok(Species species)
    {
        List<Animal> result = new List<Animal>();

        for (int i = 0; i < animals.Length; i++)
        {
            if (species == animals[i].GetSpecies())
            {
                result.Add(animals[i]);
            }
        }
        return result;
    }

    public double Average(Species species)
    {
        List<Animal> collection = new List<Animal>();
        collection = Allatok(species);

        double n = 0;
        int count = 0;

        for (int i = 0; i < collection.Count; i++)
        {
            n += collection[i].GetWeight();
            count++;
        }
        return n/count;
    }

    public bool SameSame()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            int sameSpeciesCount = 0;
            bool hasMale = false;
            bool hasFemale = false;

            for (int j = 0; j < animals.Length; j++)
            {
                if (animals[i].GetSpecies() == animals[j].GetSpecies())
                {
                    sameSpeciesCount++;
                    if (animals[j].GetSex())
                    {
                        hasMale = true;
                    }
                    else
                    {
                        hasFemale = true;
                    }
                }
            }

            if (sameSpeciesCount >= 2 && hasMale && hasFemale)
            {
                return true;
            }
        }
        return false;
    }

    public void Print()
    {
        for (int i = 0; i < animals.Length; i++)
        {
            Console.WriteLine("Név: " + animals[i].GetName() + " Neme: " + animals[i].GetSex() + " Súlya: " + animals[i].GetWeight() + "kg Faja: " + animals[i].GetSpecies());
        }
    }

}