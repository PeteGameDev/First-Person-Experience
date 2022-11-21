using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FPSPG_BasicEnemy : MonoBehaviour
{
    public Transform playerObject; 
    public float damageAmount; 
    public float attackDelay; 
    public float attackRate;
    public float attackDistance;

    NavMeshAgent nav; 

    void Start()
    {
        playerObject = GameObject.FindWithTag("Player").transform; 
        nav = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > attackDelay) 
        {
            nav.destination = playerObject.position; 
            if(Vector3.Distance(playerObject.position, transform.position) <= attackDistance)
            {
                playerObject.GetComponent<FPSPG_PlayerHealth>().playerHealth -= damageAmount;
                attackDelay = Time.time + attackRate; 
            }
        }
        else
        {
            nav.destination = transform.position;
        }
    }

}

