using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabItem : MonoBehaviour
{
    public int totalItems = 0; 

    void Awake()
    {
        //Make Collider2D as trigger 
        Debug.Log("Trigger is set");
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            totalItems++;

            Debug.Log("You currently have " + totalItems + " Coins.");

            Destroy(gameObject);
        }
    }
}
