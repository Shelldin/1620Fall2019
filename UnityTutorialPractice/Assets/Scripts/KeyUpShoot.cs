using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUpShoot : MonoBehaviour
{

    private GameObject bullet;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            bullet = new GameObject();
        }
    }
    
}
