using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent trigEvent;

    private void OnTriggerEnter(Collider other)
    {
        trigEvent.Invoke();
    }
}
