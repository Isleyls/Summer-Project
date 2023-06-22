using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPistol : MonoBehaviour
{
    public Weapon pistol = new Weapon("pistol", 1, 10, 100, 12);

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
            Debug.Log("Found a blicky!!");
            PickUpEnabled = true;
       }
    }

    void PickUp()
    {
        Inventory.instance.addItems(pistol);
        Destroy(gameObject);
    }
}
