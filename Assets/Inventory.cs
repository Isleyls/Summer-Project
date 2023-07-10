using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    [SerializeField] public List<Item> items = new List<Item>();
    [SerializeField] public List<Weapon> armory = new List<Weapon>();


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

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            World.WorldCreation.player.printInv();
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
        World.WorldCreation.player.InventoryUpdate(items, armory);
    }

    public void addWeapons(Weapon weapon2add)
    {
        bool weaponExists = false;

        foreach (Weapon weapon in armory)
        {
            if (weapon.name == weapon2add.name)
            {
                weapon.count += weapon2add.count;
                weaponExists = true;
                Debug.Log(weapon2add.name + " was added. You now have " + weapon.count + " " + weapon2add.name + "s!");
                break;
            }
        }

        if (!weaponExists)
        {
            
            armory.Add(weapon2add);
            Debug.Log(weapon2add.name + " was added.");
        }
        World.WorldCreation.player.InventoryUpdate(items, armory);
    }
}
