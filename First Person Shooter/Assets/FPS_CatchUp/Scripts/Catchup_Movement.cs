using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchup_Movement : MonoBehaviour
{
    public float walkSpeed;
    public float jumpHeight;
    float gravity = -9.81f;
    CharacterController controller;
    Vector3 velocity;
    Vector3 moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && controller.isGrounded)
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVeritcal = Input.GetAxisRaw("Vertical");
        moveDirection = (moveHorizontal * transform.right + moveVeritcal * transform.forward);
        controller.Move(moveDirection * walkSpeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
}
