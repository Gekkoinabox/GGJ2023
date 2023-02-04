using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Lift : MonoBehaviour
{
    public Transform start, finish;
    bool moveToFinish;
    public GameObject platform;

    Vector2 targetFinish, targetStart;
    Vector2 position;
    float step;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        moveToFinish = true;
        targetFinish = finish.position;
        targetStart = start.position;
        position = new Vector2(platform.transform.position.x, platform.transform.position.y);
        speed = 2f;
        
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        position = platform.transform.position;

        if(moveToFinish)
        {
            if(position != targetFinish)
            {
                //Go towards finish
                //Get Direction
                platform.transform.position = Vector2.MoveTowards(position, targetFinish, step);                
                
            }
            if(position == targetFinish)
            {
                moveToFinish = false;
            }
            
        }
        if(!moveToFinish)
        {
            if (position != targetStart)
            {
                //Go towards start
                platform.transform.position = Vector2.MoveTowards(position, targetStart, step);
                

            }
            if (position == targetStart)
            {
                moveToFinish = true;
            }
        }        

    }
}
