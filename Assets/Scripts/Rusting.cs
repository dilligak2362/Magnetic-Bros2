using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rusting : MonoBehaviour
{
    public Movement movement;
    public bool isRusting = false;
    public float rustSpeed = 20f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rust")
        {
            isRusting = true;
            movement.speed = rustSpeed;
            movement.isJumping = false;
            movement.isSprinting = false;
        }
        else
        {
            isRusting = false;
            movement.speed = movement.initialSpeed;
            movement.isJumping = true;
            movement.isSprinting = true;
        }
    }
}
