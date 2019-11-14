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
    public FloatData index;

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
            Debug.Log(index.value);
            index.value--;
            yield return wfsObj;
            
        }
    }
    
}
