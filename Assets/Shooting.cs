using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;
using System.Threading;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (World.WorldCreation.player.primWeapon != null)
            {
                //Find a way to delay the call based on rate of fire
                
                //Find a way to loop the call if the weapon is full auto
                Shoot();
            }
            else
            {
                Debug.Log("No weapon is equipped!");
            }
        }
        
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
