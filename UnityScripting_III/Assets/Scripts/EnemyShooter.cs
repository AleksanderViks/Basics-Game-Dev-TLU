using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
    public GameObject projectilePrefab;

    public void Shoot()
    {
        // Instantiate/Spawn/Create a new clone of the prefab in the scene
        // Place it where the enemy is
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
