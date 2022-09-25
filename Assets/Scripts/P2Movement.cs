using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Movement : MonoBehaviour
{
    public CharacterController2D controller;
    public P2Rusting rusting;
    public Animator animator;
    public ParticleSystem AI;

    public float initialSpeed = 40f;
    public float speed = 40f;
    public float sprintSpeed = 80f;
    float horizontalMove = 0f;

    bool crouch = false;
    public bool isJumping = true;
    public bool isSprinting = true;
    public bool isFinished = false;
    bool jump = false;
    void Start()
    {
        speed = initialSpeed;
        AI.Stop();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("HorizontalP2") * speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.RightControl) && isSprinting == true && horizontalMove != 0)
        {
            speed = sprintSpeed;
            animator.SetBool("isSprinting", true);
            AI.Play();
        }
        else if (Input.GetKeyUp(KeyCode.RightControl))
        {
            speed = initialSpeed;
            animator.SetBool("isSprinting", false);
            AI.Stop();
        }

        if (Input.GetButton("JumpP2") && isJumping == true)
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

        if (isFinished == true)
        {
            speed = 0f;
            isJumping = false;
        }
    }

    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }
}
