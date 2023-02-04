using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public Transform stoneSpawn;
    public GameObject stone;
    public float stoneSpeed = 10f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject stoneObject = Instantiate(stone, transform.position, Quaternion.identity) as GameObject;
            float shootDir = stoneSpawn.forward.x;

            stoneObject.GetComponent<Rigidbody2D>().velocity = new Vector3(stoneSpeed, 0, 0);

            //Rigidbody2D stoneInstance;

            //stoneInstance = Instantiate(stone, stoneSpawn.position, stoneSpawn.rotation);
            //stoneInstance.transform.position += Vector3.forward * stoneSpeed * Time.deltaTime;
            //stoneInstance.AddForce(stoneSpawn.forward * stoneSpeed);
        }
    }
}
