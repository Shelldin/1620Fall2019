using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public UnityEvent trigEvent;
    public float seconds = 1f;
    public bool run;

    private WaitForSeconds wfsObj;

    private void Start()
    {
        wfsObj = new WaitForSeconds(seconds);
    }


    IEnumerator OnTriggerEnter(Collider other)
    {
        run = true;
        while (run)
        {
            trigEvent.Invoke();
            yield return wfsObj;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        run = false;
    }
}
