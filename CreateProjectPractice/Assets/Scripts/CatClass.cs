using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
 public UnityEvent catStuff;

 private void OnMouseDown()
 {
  catStuff.Invoke();
 }
 
}
