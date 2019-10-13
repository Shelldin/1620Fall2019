using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class FireballMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    public float moveSpeed = 15f;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = moveSpeed;
    }
}
