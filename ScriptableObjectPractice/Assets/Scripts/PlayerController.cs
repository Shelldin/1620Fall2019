using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
    }
}
