using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 4.0f;
    public float jumpHeight = 7.0f;
    public float gravity = 400f;
    float maxVelocityChange = 200.0f;
    private Vector3 moveDirection = Vector3.zero;
    private bool canJump = true;
    private bool grounded = false;
    public Animator animShotgun;
    public  Animator animLaser;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if(targetVelocity.x!=0 || targetVelocity.z!=0)
        {
            animShotgun.SetBool("IsMovement", true);
            animLaser.SetBool("isRunning", true);

        }
        else
        {
            animShotgun.SetBool("IsMovement", false);
            animLaser.SetBool("isShooting", false);

        }
        targetVelocity = transform.TransformDirection(targetVelocity);
        targetVelocity *= speed;
        var velocity = rb.velocity;
        var velocityChange = (targetVelocity - velocity);
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;
        rb.AddForce(velocityChange, ForceMode.VelocityChange);
        if (canJump && Input.GetButton("Jump"))
        {
            rb.velocity = new Vector3(velocity.x, Mathf.Sqrt( jumpHeight * gravity), velocity.z);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        grounded = true;
    }
}
