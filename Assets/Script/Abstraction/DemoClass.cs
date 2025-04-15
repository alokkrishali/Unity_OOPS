using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Weapon sword = new Sword();
        sword.damage = 60;
        sword.Attack();
        sword.Reload();

        Weapon gun = new Gun();
        gun.damage = 110;
        gun.Attack();
        gun.Reload();

        //IWeapon sword = new Sword();
        //sword.damage = 60;
        //sword.Attack();
        //sword.Reload();


        //IWeapon gun = new Gun();
        //gun.damage = 110;
        //gun.Attack();
        //gun.Reload();
    }

}
