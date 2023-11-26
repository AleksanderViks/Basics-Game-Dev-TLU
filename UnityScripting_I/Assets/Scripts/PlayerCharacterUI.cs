using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerCharacterUI : MonoBehaviour
{
    public string playerName = "Fran";
    public int playerAge = 32;
    public float playerWeight = 74.28f;
    public bool hasKey = false;

    // Create a variable to hold a reference (link) to the UI text component in the scene
    public TextMeshProUGUI textUI;


    void Start()
    {
        //SayHello();
        //SayBye();
    }

    void Update()
    {

    }

    // We make the function `public` so that we can access it from the UI button in the scene
    // and call it when the button is clicked during gameplay
    public void SayHello()
    {
        //print("Oh hi " + playerName);


        // Using our variable `textUI` which holds a reference to the UI text component in the scene, we can then access
        // different parts of that component using the `.` (dot) operator, such as text, font, color, etc.
        // In this case, we want to change the text itself, which is stored in the `text` variable in that component

        textUI.text += "Oh hi " + playerName;
    }


    // Try doing the same as above for this function
    void SayBye()
    {
        string byeMessage = "Bye " + playerName;
        print(byeMessage);
    }

    void AddToPlayerAge(int numberToAdd)
    {
        print("Adding " + numberToAdd + " to player's age.");

        int result = playerAge + numberToAdd;

        print("The result is: " + result);
    }
}
