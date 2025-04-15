using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class Character : MonoBehaviour
{
    public virtual void Attack()
    {
        Debug.Log("Character attack");
    }
    public virtual void Attack(string mag)
    {
        Debug.Log("Character attack");
    }
}

public class Worrior : Character
{
    public override void Attack()
    {
        Debug.Log("Worrior swing a sword");
    }
    public override void Attack(string msg)
    {
        Debug.Log("Worrior swing a sword - "+msg);
    }
}
