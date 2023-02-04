using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{

    public Camera camera;
    public Transform player;
    public bool lockCamera = false;

    // Update is called once per frame
    void Update()
    {
        if (lockCamera)
        {
            camera.transform.position = player.position;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(lockCamera == false)
        {
            lockCamera = true;
        }
    }
}
