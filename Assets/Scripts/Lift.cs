using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UIElements;

public class Lift : MonoBehaviour
{
    public Transform start, finish;
    bool moveToFinish;

    Vector2 target;
    Vector2 position;
    float step;
    float speed;


    // Start is called before the first frame update
    void Start()
    {
        moveToFinish = true;
        target = finish.position;
        position = this.transform.position;
        speed = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        position = this.transform.position;

        if(moveToFinish)
        {
            if(transform.position != finish.position)
            {
                //Go towards finish
                //Get Direction
                transform.position = Vector2.MoveTowards(position, target, step);                
                
            }
        }
    }
}
