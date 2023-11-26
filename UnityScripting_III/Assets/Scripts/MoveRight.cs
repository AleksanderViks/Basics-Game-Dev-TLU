using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        // Move the GameObject towards the right of the screen
        Vector2 position = transform.position;

        Vector2 newPosition = position + new Vector2(1, 0);

        transform.position = Vector2.MoveTowards(position, newPosition, speed * Time.deltaTime);
    }
}
