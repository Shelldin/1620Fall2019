using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpMaxUp : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
   {
      PlayerController.jumpCountMax++;
   }
}
