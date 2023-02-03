using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uprooting : MonoBehaviour
{
    public bool readyForD;
    public bool readyForA = true;

    void Start()
    {
        
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && readyForA)
        {
            readyForA = false;
            Debug.Log("a pressed");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("a released");
            readyForD = true;
        }

        if (Input.GetKeyDown(KeyCode.D) && readyForD)
        {
            readyForD = false;
            Debug.Log("d pressed");
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("d released");
            readyForA = true;
        }
    }
}
