using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseFruit : MonoBehaviour
{
    public bool appleIsRipe, 
        orangeIsRipe, 
        peachIsRipe;

    void Start()
    {
        if (appleIsRipe)
        {
            print("Go pick the apple.");
        }
        else if (orangeIsRipe)
        {
            print("Go pick the orange.");
            
        }
        else if (peachIsRipe)
        {
             print("Go pick the peach.");
             
        }
        else
        {
            print("Nothing is ripe");
        }
    }

}
