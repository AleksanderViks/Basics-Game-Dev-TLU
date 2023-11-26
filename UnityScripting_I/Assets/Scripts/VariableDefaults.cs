using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableDefaults : MonoBehaviour
{
    // Since these are all public, you'll also see the default value in the Inspector window
    // when attaching this script to a game object
    public int integerVariable;
    public float floatVariable;
    public string stringVariable;
    public bool booleanVariable;


    void Start()
    {
        CheckInt();
        CheckFloat();
        CheckString();
        CheckBool();
    }

    void CheckInt()
    {
        print("The default value for int variables is: " + integerVariable);
    }

    void CheckFloat()
    {
        print("The default value for float variables is: " + floatVariable);
    }

    void CheckString()
    {
        print("The default value for string variables is: " + stringVariable);
    }

    void CheckBool()
    {
        print("The default value for boolean variables is: " + booleanVariable);
    }
}
