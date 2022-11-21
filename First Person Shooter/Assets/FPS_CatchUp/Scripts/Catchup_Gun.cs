using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catchup_Gun : MonoBehaviour
{
    public float gunDamage; 
    public float gunRange; 
    public float fireRate; 
    public float reloadTime; 
    public int magSize; 
    public int currentAmmo; 
    public int reserveAmmo; 
    public int impactForce;
    public GameObject firePoint; 
    
    public ParticleSystem muzzleFlash;
    
    float nextFire; 

    void Start()
    {
        currentAmmo = magSize;  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(firePoint.transform.position, firePoint.transform.forward, Color.green); 
        if(Input.GetButtonDown("Fire1") && Time.time > nextFire && currentAmmo > 0) 
        {
            GunShoot();
            currentAmmo--; 
        }
        if(currentAmmo <= 0 && reserveAmmo > 0) 
        {
            GunReload();
        }
        if(Input.GetKeyDown(KeyCode.R)) 
        {
            reserveAmmo = reserveAmmo + currentAmmo;
            currentAmmo = 0;
        }
    }

    void GunShoot()
    {
        muzzleFlash.Play();
        
        RaycastHit hit; 
        nextFire = Time.time + fireRate; 
        if(Physics.Raycast(firePoint.transform.position, firePoint.transform.forward, out hit, gunRange)) 
        {
            Debug.Log(hit.transform.name); 
            FPSPG_Target target = hit.transform.GetComponent<FPSPG_Target>();
            if(target != null) 
            {
                target.TakeDamage(gunDamage);
            }
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }

    void GunReload()
    {
        nextFire = Time.time + reloadTime;
        if(reserveAmmo > magSize) 
        {
            reserveAmmo = reserveAmmo - magSize; 
            currentAmmo = magSize; 
        }
        else 
        {
            currentAmmo = reserveAmmo;
            reserveAmmo = 0;
        }
    }
}
