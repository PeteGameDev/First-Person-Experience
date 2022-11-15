using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchup_Camera : MonoBehaviour
{
    public float maxX = 60f;
    public float minX = -60f;
    public float turnSpeed;
    public Camera cam;
    float rotX = 0f;
    float rotY = 0f;


    // Update is called once per frame
    void Update()
    {
        PlayerLook();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void PlayerLook()
    {
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        rotY += Input.GetAxis("Mouse X") * turnSpeed;

        rotX = Mathf.Clamp(rotX, minX, maxX);

        transform.localEulerAngles = new Vector3(0, rotY, 0);
        cam.transform.localEulerAngles = new Vector3(-rotX, 0, 0);
    }
}
