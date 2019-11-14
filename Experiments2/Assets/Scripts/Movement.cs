using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 position;

    public float moveSpeed = 10f,
        gravity = 3f,
        jumpSpeed = 30f;

    public int jumpCount = 0,
        maxJumpCount = 2;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        position.x = Input.GetAxis("Horizontal") * moveSpeed;
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
