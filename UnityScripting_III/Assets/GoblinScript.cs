using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinScript : MonoBehaviour
{
    public GameObject apple;

    // Start is called before the first frame update
    void Start()
    {
        AppleScript appleScript = apple.GetComponent<AppleScript>();
        if (appleScript != null)
        {
            appleScript.Eat();
        }
        else
        {
            print("No AppleScript found!");
        }
     
    }

    // Update is called once per frame
    void Update()
    {

    }
}
