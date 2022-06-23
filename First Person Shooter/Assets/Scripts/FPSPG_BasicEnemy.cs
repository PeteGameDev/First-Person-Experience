using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/*
* TASK: Fix the 10 errors in this code
    * Unity console will tell you where errors are and what they are, you just need to read it carefully
    * Google is your friend!
* TASK: Comment on each line of code to explain it
* TASK: Create another enemy which acts differently to this one
*/

public class FPSPG_BasicEnemy : MonoBehaviour
{
    public Transform playerObject; //What's this for?
    public float damageAmount; //Could all these floats be written neater? Maybe as a single line? 
    public float attackDelay; 
    public float attackRate;
    public float attackDistance;

    NavMeshAgent nav; //What's this?

    void Start()
    {
        playerObject = GameObject.FindWithTag("Player").transform; //What is this doing?
        nav = GetComponent<NavMeshAgent>(); //Why do this?
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > attackDelay) //What is the condition here?
        {
            nav.destination = playerObject.position; //What's this for?
            if(Vector3.Distance(playerObject.position, transform.position) <= attackDistance) //What's the condition here?
            {
                playerObject.GetComponent<FPSPG_PlayerHealth>().playerHealth -= damageAmount; //What is this?
                attackDelay = Time.time + attackRate; //What's this for?
            }
        }
        else
        {
            nav.destination = transform.position;
        }
    }

}

