using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineClass : MonoBehaviour
{
    public UnityEvent coEvent;
    private WaitForSeconds wfsObj;
    public float seconds = 3f;
    public bool canRun = true;
    public IntData index;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds); 
    }

    public void Run()
    {
        StartCoroutine(OnRun());
    }

    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            yield return wfsObj;
            Debug.Log(index.value);
            index.value--;
            
            
        }
    }
    
}
