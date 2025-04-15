using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 100;

    public int Health
    {
        get 
        {
            return health;
            }
        set 
        { 
            health = Mathf.Clamp(value, 0, 100);
        }
    }

    public void PlayerDamage(int damageValue = 0)
    {
        Health -= damageValue;
        Debug.Log("Player damage "+Health);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
