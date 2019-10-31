
using UnityEngine;

public class MovementZ : MonoBehaviour
{

    public float gravity = 3f;
    public float speed = 1f;
    public float jumpSpeed = 10f;

    private int jumpCount = 2;

    private Vector3 position;
    public CharacterController controller;

   
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");
        position.z = speed*Input.GetAxis("Vertical");

        position.y -= gravity;

        if (!controller.isGrounded )
        {

           
            position.y -= gravity;
        }
        else
        {
            jumpCount = 2;
        }
        
        
        if (Input.GetButtonDown("Jump") && jumpCount > 0)
        {
            
            jumpCount--;
            position.y = jumpSpeed;
        }
        controller.Move(position*Time.deltaTime);
        
    }
}

