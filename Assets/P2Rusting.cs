using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Rusting : MonoBehaviour
{
    public P2Movement p2Movement;
    public bool isRusting = false;
    public float rustSpeed = 20f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "rust2")
        {
            isRusting = true;
            p2Movement.speed = rustSpeed;
            p2Movement.isJumping = false;
            p2Movement.isSprinting = false;
        }
        else
        {
            isRusting = false;
            p2Movement.speed = p2Movement.initialSpeed;
            p2Movement.isJumping = true;
            p2Movement.isSprinting = true;
        }
    }
}
