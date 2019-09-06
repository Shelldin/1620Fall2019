using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

public class RandomTests : MonoBehaviour
{

    public string noob = "I really have no idea what I'm doing";

    public UnityEvent Ereignis;

    private void OnTriggerEnter(Collider other)
    {
        Ereignis.Invoke();
    }

    //couldn't get this to work. I'll try again later.
    private void OnMouseOver()
    {
        
    }
       
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
