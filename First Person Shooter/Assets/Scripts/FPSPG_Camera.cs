using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* For those of you who are struggling with programming
* Replace the comments on this script with what the line does
* You might need to use Google to find out
* TIP: Don't overthink it
*/ 

//What's this class for?
public class FPSPG_Camera : MonoBehaviour
{
    public float maximumX = 60f; //What is this?
    public float minimumX = -60f; //What is this?
    public float turnSpeed = 5f; //What is this?
    public Camera cam; //What is this for?
    float rotX = 0f;
    float rotY = 0f; 

    void Update()
    {
        PlayerLook();
        Cursor.lockState = CursorLockMode.Locked; //What does this do?
    }

    void PlayerLook()
    {
        rotX += Input.GetAxis("Mouse Y") * turnSpeed; //Why is rotX on mouse Y?
        rotY += Input.GetAxis("Mouse X") * turnSpeed; //Why is rotY on mouse X?

        rotX = Mathf.Clamp(rotX, minimumX, maximumX); //What does Clamp do?

        transform.localEulerAngles = new Vector3(0, rotY, 0); //What does a Euler Angle do?
        cam.transform.localEulerAngles = new Vector3(-rotX, 0, 0); //Why do we need 3 things after a vector3?
    }
}
