using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseDownShot : MonoBehaviour
{
   public UnityEvent shoot;

   public void OnMouseDown()
   {
      shoot.Invoke();
   }
}
