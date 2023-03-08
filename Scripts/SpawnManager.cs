using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   //create an array of obstacles to spawn in
    public GameObject[] obstaclePrefabs;

    //Spawn possition variables
    public float spawnPosX = 10;
    public float spawnPosY;

    //Variables for invoke 
    private float startDelay = 3f;
    private float spawnReplay = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnReplay);
    }

    void Update()
    {
        spawnPosY = transform.position.y;
    }
    
    //Function will choose random obstacle to spawn 
    private void SpawnObstacles()
    {
        Vector2 spawnPos = new Vector2(spawnPosX + 0.4f, spawnPosY + 10);

        int obstacles = Random.Range(0, 3);

        Instantiate(obstaclePrefabs[obstacles], spawnPos, obstaclePrefabs[obstacles].transform.rotation);
    }
}
