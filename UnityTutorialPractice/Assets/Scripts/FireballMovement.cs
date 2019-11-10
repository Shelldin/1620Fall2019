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
    public GameObject prefab;
    
    private void Start()
    {

        position = prefab.transform.position; 
        controller = GetComponent<CharacterController>();
    }

    private void Awake()
    {
        position = prefab.transform.position;
    }

    void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = moveSpeed;
    }
}

