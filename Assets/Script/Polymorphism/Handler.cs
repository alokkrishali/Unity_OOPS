using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    
    void Start()
    {
        Character warrior = new Worrior();
        Character mage = new Mage();

        warrior.Attack();
        mage.Attack();

        warrior.Attack(" Hey ");
        mage.Attack(" Hello ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
