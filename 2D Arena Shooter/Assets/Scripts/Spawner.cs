using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
     public float spawnTime;
     //The amount of time between each spawn.
     public float spawnDelay;
     //The amount of time before spawning starts.
     public GameObject[] enemies;
     //Array of enemy prefabs.
     //public Vector3 enposition;
     void Start ()
     {
         //Start calling the Spawn function repeatedly after a delay.
         InvokeRepeating("Spawn", spawnDelay, spawnTime);
     }
     void Spawn ()
     {
         //Instantiate a random enemy.
         int enemyIndex = Random.Range(0, enemies.Length);
         //Instantiate(enemies[enemyIndex], enposition, transform.rotation);
		 Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
     }

}
