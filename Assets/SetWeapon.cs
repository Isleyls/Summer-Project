using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using World;

public class SetWeapon : MonoBehaviour
{
    Weapon new_weapon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && Player.armory.Count != 0)
        {
            equipWeapon();
        }
    }

    public void equipWeapon()
    {
        
        World.WorldCreation.player.primWeapon = Player.armory[0];
        Debug.Log(World.WorldCreation.player.primWeapon.name + " was equipped!");
    }
}
