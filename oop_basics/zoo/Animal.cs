namespace zoo;

public enum Species{Dog, Panda, Rabbit};

public class Animal
{
    private string name;
    private bool sex;
    private int weight;
    private Species species;

    public Animal(string name, bool sex, int weight, Species species)
    {
        this.name = name;
        this.sex = sex;
        this.weight = weight;
        this.species = species;
    }
    public string GetName() { return name; }
    //public void setName(string name) { this.name = name; }
    
    public bool GetSex() { return sex; }
    //public void setSex(bool sex) { this.sex = sex; }
    
    public int GetWeight() { return weight; }
    //public void  setWeight(int weight)  { this.weight = weight; }
    
    public Species GetSpecies() { return species; }
    //public void setSpecies(Species species) { this.species = species; }
}