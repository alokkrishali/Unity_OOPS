using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{
    public override void Attack()
    {
        Debug.Log("Attacked by bullets by gamage ");
    }

    //public void Reload()
    //{
    //    Debug.Log("Gun is under Loading ");
    //}
}
