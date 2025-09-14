using UnityEngine;

public class GameManager : MonoBehaviour  
{
    Chicken chicken = new Chicken("KFC", 10, 5); 
    Cow cow = new Cow("Burger King", 5, 5000);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log($"Welcome to the farm! We currently only got {chicken.Name} the chicken and {cow.Name} the cow.");
        cow.GetStatus();
        chicken.GetStatus();

        cow.AdjustHappiness(10);
        chicken.AdjustHappiness(-5);

        cow.AdjustHunger(-10);
        chicken.AdjustHunger(10);

        cow.GetStatus();
        chicken.GetStatus();

        cow.MakeSound();
        chicken.MakeSound();

        cow.Feed("Steak");
        chicken.Feed("Fried chicken");

        cow.GetStatus();
        chicken.GetStatus();

        cow.Moo();
        chicken.Sleep();

        cow.GetStatus();
        chicken.GetStatus();
    }
}
