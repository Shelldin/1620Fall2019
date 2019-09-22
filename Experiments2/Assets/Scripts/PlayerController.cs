﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 position;
    private int jumpCount = 0;

    public int maxJumpCount = 2;

    public float moveSpeed = 10f,
        gravity = 3f,
        jumpSpeed = 30f;
    
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

        if (Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
    }
}
