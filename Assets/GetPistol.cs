using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPistol : MonoBehaviour
{
    public Weapon pistol = new Weapon("pistol", 1, 10, 100, 12, 5, "Semi-Automatic", "9mm");

    public bool PickUpEnabled;

    void Update()
    {
        if (PickUpEnabled && Input.GetKeyDown(KeyCode.E))
        {
            PickUp();
        }
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
       if (c2d.gameObject.name.Equals("Player"))
       {
            Debug.Log("Found a Pistol!");
            PickUpEnabled = true;
       }
    }

    void PickUp()
    {
        Inventory.instance.addWeapons(pistol);
        Destroy(gameObject);
    }
}
