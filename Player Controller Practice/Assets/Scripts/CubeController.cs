using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed = 10f;
    public float gravity = 3f;
    public float jumpSpeed = 25f;

    private int jumpCount = 1;

    public Vector3 position;
    public CharacterController controller;
    void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = speed * Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y -= gravity;
        }

        else
        {
            jumpCount = 1;
        }

        if (Input.GetButtonDown("Jump") && jumpCount >0)
        {
            jumpCount--;
            position.y = jumpSpeed;
        }
    }
}
