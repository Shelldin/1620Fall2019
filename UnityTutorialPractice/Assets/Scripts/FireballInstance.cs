using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballInstance : MonoBehaviour
{
    public GameObject prefab;
    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))//from tutorial
        {
            Instantiate(prefab);
        }   
    }
}
