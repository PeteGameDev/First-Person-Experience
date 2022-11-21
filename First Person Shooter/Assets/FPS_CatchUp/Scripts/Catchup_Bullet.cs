using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchup_Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Target"))
        {
            Destroy(other.gameObject);
        }
    }
}
