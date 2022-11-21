using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchup_InstantiateGun : MonoBehaviour
{
    public GameObject bullet;
    public GameObject firePoint;

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }   
    }

    void Shoot()
    {
        GameObject clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(clone, 10f);
    }
}
