using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    public override void Attack()
    {
        Debug.Log(" Mage casts a fireball");
    }
    public override void Attack(string msg)
    {
        Debug.Log(" Mage casts a fireball - "+msg);
    }
}
