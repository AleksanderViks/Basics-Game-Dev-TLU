using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public List<Enemy> enemies;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakeAllEnemiesThrowApples();
        }
    }

    void MakeAllEnemiesThrowApples()
    {
        print("All goblins will throw apples! Number of goblins is... " );

        for (int i = 0; i < enemies.Count; i++)
        {
            Enemy enemy = enemies[i];

            EnemyShooter shooter = enemy.GetComponent<EnemyShooter>();
            if (shooter != null)
            {
                shooter.Shoot();
            }
            else
            {
                print("EnemyShooter component not found!");
            }
        }
    }
}
