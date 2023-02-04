using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            //Collided with player so kill them
            
        }
    }
}
