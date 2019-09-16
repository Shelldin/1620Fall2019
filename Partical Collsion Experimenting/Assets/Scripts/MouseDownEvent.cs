using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseDownEvent : MonoBehaviour
{
   public UnityEvent mouseDown;

   private void OnMouseDown()
   {
      mouseDown.Invoke();
   }
}
