using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CoroutinesExample : MonoBehaviour
{

    public float seconds = 1f;
    
    private int i = 3;
    private WaitForSeconds wfsObj;

    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    IEnumerator Start()
    {
        while (i>0)
        {
            yield return wfsObj;
                    Debug.Log(i);
                    i--;
        }
        yield return new WaitForSeconds(1f);
        Debug.Log("GO!");
        
        // additional notes
        // yield return new WaitForSeconds(1f);
       // Debug.Log(3);
       // Invoke(nameof(StartLater), 3f);

    }

    void StartLater()
    {
        Debug.Log("ran");
    }

 


    
}
