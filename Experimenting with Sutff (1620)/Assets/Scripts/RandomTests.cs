using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class RandomTests : MonoBehaviour
{

    public string noob = "I really have no idea what I'm doing";

    public UnityEvent Ereignis;
    public UnityEvent Geschenis;

    private void OnTriggerEnter(Collider other)
    {
        Ereignis.Invoke();
    }

    private void OnTriggerStay(Collider other)
    {
        Ereignis.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        Geschenis.Invoke();
    }

   
    private void OnMouseOver()
    {
        print(message: noob);        
    }
   
}
