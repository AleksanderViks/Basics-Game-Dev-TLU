using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Racer : MonoBehaviour
{
    public string carModel = "Huracan Evo";
    public string engineType = "Naturally Aspirated V10";
    public string carMaker = "Lamborghini";

    public int carWeight = 1665;
    public int yearMade = 2019;

    public float maxAcceleration = 1.06f;

    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = false;

    public class Fuel
    { 
        public int fuelLevel;
        public Fuel(int amount)
        {
            fuelLevel = amount;
        }
    }
    public Fuel carFuel = new Fuel(100);

    void Start()
    {
               print("The racer model is " + carModel + " It is manufactured by " + carMaker + ". It has a " + engineType + " engine.");
        CheckWeight();


        if (yearMade <= 2009)
        {
            print("It was first introduced in " + yearMade);

            int carAge = CalculateAge(yearMade);

            print("That makes it " + carAge + " years old.");

        }
        else
        {
            print("It was introduced in the 2010's");
            print("And its maximum acceleration is " + maxAcceleration + " m/s2");
        }

        print(CheckCharacteristics());
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }
    void ConsumeFuel()
    {
        carFuel.fuelLevel -= 10;
    }
    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel) 
        {
            case 70:
                print("Fuel level is nearing two-thirds");
                break;
            case 50:
                print("Fuel level is at half amount");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report");
                break;
        }
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The " + carModel + "weighs less than 1500 kg.");
        }
        else
        {
            print("The " + carModel + "weighs over 1500 kg.");
        }
    }

    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car is a sedan type.";

        }
        else if (hasFrontEngine)
        {
            return "The car isn't a sedan, but has a front engine.";

        }
        else
        {
            return "The car is neither a sedan, nor is its engine a front engine.";
        }
    }
}