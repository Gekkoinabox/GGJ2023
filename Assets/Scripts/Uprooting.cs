using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uprooting : MonoBehaviour
{
    public bool readyForD;
    public bool readyForA = true;
    int counter;
    private Animator anim;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
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
                RotateSprite(0);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.A))
            { 
                readyForD = true;
            }

            if (Input.GetKeyDown(KeyCode.D) && readyForD && counter % 2 == 0)
            {
                readyForD = false;
                RotateSprite(1);
                counter++;
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                Debug.Log("d released. Counter: " + counter);
                readyForA = true;
            }
        }

        else if (counter >= 6)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 0);
            anim.Play("JumpOut");
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
