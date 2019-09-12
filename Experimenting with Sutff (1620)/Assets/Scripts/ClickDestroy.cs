using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickDestroy : MonoBehaviour
{
    public UnityEvent Vernichtung;
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Vernichtung.Invoke();
    }
}
