using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float SpawnRate = 1f;
    public GameObject hexagon;
    public float nextTimeToSpawn = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextTimeToSpawn)
        {
            Instantiate(hexagon, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1f / SpawnRate;
        }
    }
}
