using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PartColEvent : MonoBehaviour
{
    public UnityEvent partCol;

    private void OnParticleCollision(GameObject other)
    {
        partCol.Invoke();
    }
}
