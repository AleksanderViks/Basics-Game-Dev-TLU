using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDialogue : MonoBehaviour
{
    public string greetMessage;
    public string shoutMessage;

    public void Greet()
    {
        print(greetMessage);
    }

    public void Shout()
    {
        print(shoutMessage);
    }
}
