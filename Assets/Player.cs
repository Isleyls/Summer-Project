
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

[System.Serializable]
public class Player
{
    public string playerName;
    public int gunSkill;
    public int meleeSkill;
    public int medicine;
    public int charisma;
    public int engineering;
    public int endurance;
    public int smarts;
    public static List<Item> items = new List<Item>();

    public Player(string name, int gun, int melee, int med, int charm, int eng, int end, int intel)
    {
        playerName = name;
        gunSkill = gun;
        meleeSkill = melee;
        medicine = med;
        charisma = charm;
        engineering = eng;
        endurance = end;
        smarts = intel;
    }

    public void test()
    {
        Debug.Log("Hello");
    }

   public void InventoryUpdate(List<Item> list)
   {
        items = list;
        Debug.Log("Inventory update");
   }

}
