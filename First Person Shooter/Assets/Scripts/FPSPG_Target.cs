using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSPG_Target : MonoBehaviour
{
    public float health = 50f;

    GameObject enemySpawnObject;

    private void Start() {
        enemySpawnObject = GameObject.Find("Spawner");
    }
    public void TakeDamage(float amount) 
    {
        health -= amount; 
        if(health <= 0f)
        {
            TargetDie();
        }
    }

    void TargetDie()
    {
        Destroy(gameObject);
        enemySpawnObject.GetComponent<EnemySpawn>().numberOfEnemies--;

    }
}
