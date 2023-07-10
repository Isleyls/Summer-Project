using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTech9 : MonoBehaviour
{
    public Weapon pistol = new Weapon("tech-9", 1, 10, 100, 18, 10, "Fully-Automatic", "9mm");

    public bool PickUpEnabled;

    void Start()
    {

    }

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
            Debug.Log("Found a Tech-9!");
            PickUpEnabled = true;
       }
    }

    void PickUp()
    {
        Inventory.instance.addWeapons(pistol);
        Destroy(gameObject);
    }
}
