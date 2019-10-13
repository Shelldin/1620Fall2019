using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionEvent : MonoBehaviour
{
  public UnityEvent collEvent;

  private void OnControllerColliderHit(ControllerColliderHit hit)
  {
    collEvent.Invoke();
  }
}
