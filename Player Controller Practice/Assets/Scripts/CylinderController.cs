using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CylinderController : MonoBehaviour
{
    private Vector3 position;
    public CharacterController controller;
    private int jumpCount = 0;
    
    public int jumpCountMax = 2;
    public float moveSpeed = 10f,
        gravity = 3f,
        jumpSpeed = 25f;
    
    

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        controller.Move(position * Time.deltaTime);

        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
        else
        {
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            jumpCount++;
            position.y = jumpSpeed;
        }
    }
}
