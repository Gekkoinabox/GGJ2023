using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{

    public Camera camera;
    public Transform player;
    public float yoffset;
    public bool lockCamera = false;

    // Update is called once per frame
    void Update()
    {
        if (lockCamera)
        {

            camera.transform.position = new Vector3(player.position.x, player.position.y + yoffset, camera.transform.position.z);
            
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
