using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public int health = 100;

   public void TakeDamage(int damageValue = 10)
   {
        Debug.Log("Before Damage - "+health);
        health -= damageValue;
        Debug.Log("After Damage - "+health);
   }
}
