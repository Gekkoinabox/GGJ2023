using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uprooting : MonoBehaviour
{
    public bool readyForD;
    public bool readyForA = true;
    int counter;

    void Start()
    {
        counter = 1;
    }
    
    void Update()
    {
        //counter for A and D

        if (counter <= 6)
        {
            if (Input.GetKeyDown(KeyCode.A) && readyForA && counter % 2 != 0)
            {
                readyForA = false;
                Debug.Log("a pressed. Counter: " + counter);
                RotateSprite(0);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                Debug.Log("a released");
                readyForD = true;
            }

            if (Input.GetKeyDown(KeyCode.D) && readyForD && counter % 2 == 0)
            {
                readyForD = false;
                Debug.Log("d pressed. Counter: " + counter);
                RotateSprite(1);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("d pressed. Counter: " + counter);
                readyForA = true;
            }
        }
    }

    //Rotate sprite
    void RotateSprite(int direction)
    {
        if (direction == 0)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 25);
        }
        if(direction == 1)
        {
            this.transform.eulerAngles = new Vector3(0, 0, -25);
        }
    }
}
