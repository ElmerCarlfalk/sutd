using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawnPoint;
    float spawnRange; 
    public float spawnRate = 2f;  // Mellanrum mellan spawns
    float nextSpawn = 0.0f;  //variabel för nästa spawn
    // Start is called before the first frame update
    void Start()
    {
        //spawnRange = Random.Range()
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Instantiate(enemy, spawnPoint);
        }
    }
}
