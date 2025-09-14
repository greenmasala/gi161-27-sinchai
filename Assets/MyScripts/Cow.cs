using UnityEngine;

class Cow
{
    
    private string name; 
    public string Name
    {
        get => name;
        set => name = string.IsNullOrEmpty(value) ? "Unknown" : value; //if name is blank, then set name to "Unknown"
    }

    
    private int hunger;
    public int Hunger
    {
        get => hunger;
        set => hunger = (value <= 0) ? 0 : (value >= 50) ? 50 : value; 
    }

    private int happiness;
    public int Happiness
    {
        get => happiness;
        set => happiness = (value <= 0) ? 0 : (value >= 50) ? 50 : value; 
    }

    private float milk;
    public float Milk
    {
        get => milk;
        set => milk = (value <= 0) ? 0 : value;
    }

    //Constructor to create an object
    public Cow(string newName, int newHunger, int newHappy) //assigning values to attributes above
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappy;
        Milk = 0;
    }

    public void AdjustHunger(int hungerChange)
    {
        Hunger += hungerChange;
        Debug.Log($"{Name}'s hunger value changed by: {hungerChange}");
    }

    public void AdjustHappiness(int happinessChange)
    {
        Happiness += happinessChange;
        Debug.Log($"{Name}'s happiness value changed by: {happinessChange}");
    }

    public void MakeSound()
    {
        Debug.Log("Mooo!");
    }

    public void Feed(string food) //getting gold from monster (GET IN MAIN)
    {
        Debug.Log($"{food} was fed to {Name}. Hunger decreased by 5 and Happiness increased by 5!");
        Hunger -= 5;
        Happiness += 5;
    }

    public void Moo()
    {
        Debug.Log($"{Name} mooed very loudly! Looks like someone's in a good mood. Happiness increased by 10!");
        Hunger += 10;
    }

    public void GetStatus()
    {
        Debug.Log($"Cow name: {Name} Hunger: {Hunger} Happiness: {Happiness} Milk: {Milk} ");
    }
}
