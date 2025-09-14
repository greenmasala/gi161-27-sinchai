using Unity.VisualScripting;
using UnityEngine;

class Chicken
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

    private int eggs;
    public int Eggs
    {
        get => eggs;
        set => eggs = (value <= 0) ? 0 : value;
    }

    //Constructor to create an object
    public Chicken(string newName, int newHunger, int newHappy) //assigning values to attributes above
    {
        Name = newName;
        Hunger = newHunger;
        Happiness = newHappy;
        Eggs = 0;
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
        Debug.Log("B'kawk!");
    }

    public void Feed(string food) //getting gold from monster (GET IN MAIN)
    {
        Debug.Log($"{food} was fed to {Name}. Hunger decreased by 5 and Happiness increased by 5!");
        Hunger -= 5;
        Happiness += 5;
    }

    public void Sleep()
    {
        Debug.Log($"{Name} slept. Hunger increased by 2 and Happiness increased by 5!");
        Hunger += 2;
        Happiness += 5;
    }
    
    public void GetStatus()
    {
        Debug.Log($"Chicken name: {Name} Hunger: {Hunger} Happiness: {Happiness} Eggs: {Eggs} ");
    }
}
