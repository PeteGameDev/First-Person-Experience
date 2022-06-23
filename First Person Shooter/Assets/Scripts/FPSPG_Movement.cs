using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* For those of you who are struggling with programming
* Replace the comments on this script with what the line does
* You might need to use Google to find out
* TIP: Don't overthink it
*/ 

//What is this class for?
public class FPSPG_Movement : MonoBehaviour
{
    Vector3 moveDirection; //What is a vector?
    Rigidbody rb; //What does a Rigidbody do?
    public float walkSpeed; //Why is this public? What is a float?
    
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //What does this line do?
    }
    void FixedUpdate() //What's the difference between this and Update?
    {
        PlayerWalk(); //What's this for?
    }
    //What is this function for?
    void PlayerWalk()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal"); //What does this line do?
        float moveVertical = Input.GetAxisRaw("Vertical"); //What does this line do?

        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward).normalized; //What does this line do?
        rb.velocity = moveDirection * (walkSpeed * 100) * Time.deltaTime; //What does this line do?
    }
}
