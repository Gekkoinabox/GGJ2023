using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public Transform stoneSpawn;
    public GameObject stone;
    public float stoneSpeed = 10f;
    public PlayerMovementv2 pMV2;

    private void Update()
    {
        // player shooting mechanics
        if (Input.GetKeyDown(KeyCode.P))
        {
            // if player is facing right
            if (pMV2.GetDirection() == 1)
            {
                GameObject stoneObject = Instantiate(stone, transform.position, Quaternion.identity);
                stoneObject.GetComponent<Rigidbody2D>().velocity = new Vector3(stoneSpeed, 0, 0);
            }

            // if player is facing left
            else if (pMV2.GetDirection() == 0)
            {
                GameObject stoneObject = Instantiate(stone, transform.position, Quaternion.identity);
                stoneObject.GetComponent<Rigidbody2D>().velocity = new Vector3(-stoneSpeed, 0, 0);
            }
        }
    }
}
