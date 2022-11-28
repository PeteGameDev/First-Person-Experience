using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyObject;
    public GameObject[] spawnPoints;
    public float numberOfEnemies, maxEnemies;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        InvokeRepeating("SpawnEnemies", 0.5f, 2f);
    }

    void SpawnEnemies(){
        for(int i = 0; i < spawnPoints.Length; i++)
        {
                if(numberOfEnemies < maxEnemies){
                Instantiate(enemyObject, spawnPoints[Random.Range(0, spawnPoints.Length)].transform);
                numberOfEnemies++;
            }
        }
    }

}
