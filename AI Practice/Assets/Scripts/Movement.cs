using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 position;

    public float moveSpeed = 10f;
    
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

   
    void Update()
    {
        controller.Move(position * Time.deltaTime);
        position.x = moveSpeed * Input.GetAxis("Horizontal");
    }
}
