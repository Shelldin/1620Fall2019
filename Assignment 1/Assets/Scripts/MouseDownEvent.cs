using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
    public UnityEvent mouseEvent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseEvent.Invoke();
        }
    }
}
