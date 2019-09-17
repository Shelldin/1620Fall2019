using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnParticleCollsion : MonoBehaviour
{
   public UnityEvent parCol;

   private void OnParticleCollision(GameObject other)
   {
      parCol.Invoke();
   }
}
