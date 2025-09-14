using UnityEngine;

public class GameManager : MonoBehaviour  
{
    Chicken chicken = new Chicken("KFC", 10, 5); 
    Cow cow = new Cow("Burger King", 5, -10);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Welcome to the farm! We currently only got {chicken.Name} the chicken and {cow.Name} the cow.");
        cow.GetStatus();
        cow.AdjustHappiness(10);
        cow.AdjustHunger(-10);
        cow.GetStatus();
        cow.MakeSound();
        cow.Feed("Steak");
        cow.GetStatus();
        cow.Moo();
        cow.GetStatus();

        chicken.GetStatus();
        chicken.AdjustHappiness(-5);
        chicken.AdjustHunger(10);
        chicken.GetStatus();
        chicken.MakeSound();
        chicken.Feed("Fried chicken");
        chicken.GetStatus();
        chicken.Sleep();
        chicken.GetStatus();
    }
}
