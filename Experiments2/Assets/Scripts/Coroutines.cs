﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public UnityEvent coEvent;
    private WaitForSeconds wfsObj;
    public float seconds = 3f;
    public bool canRun = true;

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
        while (canRun)
        {
            coEvent.Invoke();
            yield return wfsObj;
            
        }
    }
    
}