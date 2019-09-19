using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MovePractice : MonoBehaviour
{
    public float moveSpeed = 10f,
        gravity = 9.8f,
        jumpSpeed = 30f;

    public int jumpCountMax = 2;


    private int jumpCount = 0;
    private Vector3 position;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(position * Time.deltaTime);

        position.x = moveSpeed*Input.GetAxis("Horizontal");

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
