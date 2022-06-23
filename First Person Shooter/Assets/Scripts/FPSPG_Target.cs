using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* For those of you who are struggling with programming
* Replace the comments on this script with what the line does
* You might need to use Google to find out
* TIP: Don't overthink it
*/ 

public class FPSPG_Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount) //Why is this function public?
    {
        health -= amount; //What does this mean?
        if(health <= 0f)//What is the condition here?
        {
            TargetDie();
        }
    }

    void TargetDie()//what does this function do?
    {
        Destroy(gameObject);//what object will this destroy?
    }
}
