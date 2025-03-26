using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon
{
   public int damage;

   public abstract void Attack();

   public void Reload()
   {
    Debug.Log("Weapon is loading");
   }
    
}
