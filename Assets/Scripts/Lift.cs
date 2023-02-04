using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UIElements;

public class Lift : MonoBehaviour
{
    public Transform start, finish;
    bool moveToFinish;
    public GameObject platform;

    Vector2 target;
    Vector2 position;
    float step;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        moveToFinish = true;
        target = finish.position;
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
            if(platform.transform.position != finish.position)
            {
                //Go towards finish
                //Get Direction
                platform.transform.position = Vector2.MoveTowards(position, target, step);                
                
            }
            if(platform.transform.position == finish.position)
            {
                moveToFinish = false;
            }
            
        }
        if(!moveToFinish)
        {
            if (platform.transform.position != start.position)
            {
                //Go towards start
                platform.transform.position = Vector2.MoveTowards(position, target, step);
                

            }
            if (platform.transform.position == start.position)
            {
                moveToFinish = true;
            }
        }
    }
}
