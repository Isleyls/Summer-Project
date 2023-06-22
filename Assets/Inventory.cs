using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    [SerializeField] public List<Item> items = new List<Item>();

    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    public void addItems(Item item2add)
    {
        bool itemExists = false;

        foreach (Item item in items)
        {
            if (item.name == item2add.name)
            {
                item.count += item2add.count;
                itemExists = true;
                Debug.Log(item2add.name + " was added. You now have " + item.count + " " + item2add.name + "s!");
                break;
            }
        }

        if (!itemExists)
        {
            
            items.Add(item2add);
            Debug.Log(item2add.name + " was added.");
        }
        World.WorldCreation.player.InventoryUpdate(items);
    }
}
