using System;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(Collider))]
public class TrigEvent : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;

    private void Awake()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    { 
        triggerEnterEvent.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}