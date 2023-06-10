using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public CharacterController controller;
    private float speed; 
    public float walkSpeed = 5f;
    public float runSpeed = 10f;
    public float turnSpeed = 90f; 
    public float jumpSpeed = 8f;
    public float gravity = 9.8f;
    private float vSpeed = 0f; 

    void Update()
    {
        if (Input.GetButton("Fire3"))
        {
            transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            Vector3 vel = transform.forward * Input.GetAxis("Vertical") * runSpeed;
            if (controller.isGrounded)
            {
                vSpeed = 0;
                if (Input.GetButtonDown("Jump"))
                { 
                    vSpeed = jumpSpeed;
                }
            }
            vSpeed -= gravity * Time.deltaTime;
            vel.y = vSpeed; 
            controller.Move(vel * Time.deltaTime);
        }
        else
        {
            speed = walkSpeed;
            transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
            Vector3 vel = transform.forward * Input.GetAxis("Vertical") * walkSpeed;
            if (controller.isGrounded)
            {
                vSpeed = 0;
                if (Input.GetButtonDown("Jump"))
                {
                    vSpeed = jumpSpeed;
                }
            }
            vSpeed -= gravity * Time.deltaTime;
            vel.y = vSpeed;
            controller.Move(vel * Time.deltaTime);
        }
    }
}
