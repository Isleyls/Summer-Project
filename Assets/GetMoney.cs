using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMoney : MonoBehaviour
{
    public Item money = new Item("money", 1);

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
            Debug.Log("Stepped on that mula baby!!");
            PickUpEnabled = true;
       }
    }

    void PickUp()
    {
        Inventory.instance.addItems(money);
        Destroy(gameObject);
    }
}
