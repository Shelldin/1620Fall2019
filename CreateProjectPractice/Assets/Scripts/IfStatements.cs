using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 5,
        b = 5,
        c = 10;

    public string password = "OU812";
    public bool lightsOn = true;
    void Start()
    {
        if (a+b == c)
        {
            print(true);
        }
        else
        {
            print(false);
        }

        if (password == "OU812")
        {
            print(true);
        }

        if (lightsOn)
        {
            print(true);
        }
    }

}
