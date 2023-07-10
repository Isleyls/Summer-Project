using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getMagnum : MonoBehaviour
{
    // Start is called before the first frame update
    public Weapon pistol = new Weapon("magnum", 1, 30, 100, 6, 3, "Semi-Automatic", "357Mag");

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
            Debug.Log("Big Iron, Big Iron...");
            PickUpEnabled = true;
       }
    }

    void PickUp()
    {
        Inventory.instance.addWeapons(pistol);
        Destroy(gameObject);
    }
}
