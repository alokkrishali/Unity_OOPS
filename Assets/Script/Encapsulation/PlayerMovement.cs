using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 20; // Encapsulate this field
    [SerializeField] Transform cube;
    public float Speed
    {
        get 
        {
            return speed;
        }
        set
        {
            speed = Mathf.Clamp(value, 0, 20); // restrict speed range
        }
    }
    private void Movement()
    {
        float move = Input.GetAxis("Horizontal")*Speed*Time.deltaTime;
        cube.Translate(move, 0,0);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
}
