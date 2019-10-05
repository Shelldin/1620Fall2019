using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;

    public CharacterData playerData;
    
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //playerData = GetComponent<CharacterData>(); not sure if I need this or how to get a specific CharacterData
    }


    private void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = playerData.moveSpeed * Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y -= playerData.gravity;
        }
        else
        {
            playerData.jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && playerData.jumpCount < playerData.jumpCountMax)
        {
            playerData.jumpCount++;
            position.y = playerData.jumpSpeed;
        }
    }
}
