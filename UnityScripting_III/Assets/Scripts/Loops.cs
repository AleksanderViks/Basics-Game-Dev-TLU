using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CountUsingWhileLoop();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            CountUsingForLoop();
        }
    }

    void CountUsingWhileLoop()
    {
        print("Counting using a While loop");

        int i = 0;
        while (i < 10)
        {
            print(i);
            i++;
        }
    }

    void CountUsingForLoop()
    {
        print("Counting using a For loop");

        for (int i = 0; i < 10; i++)
        {
            print(i);
        }
    }
}
