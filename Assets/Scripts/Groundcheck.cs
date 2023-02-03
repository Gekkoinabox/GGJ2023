using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    public PlayerMovement playerMovement;

    // checking if the groundcheck is touching the ground
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("hit ground");

        //if (other.gameObject.tag == "Ground")
        //{
        //    playerMovement.isGrounded = true;
        //}

        //else
        //{
        //    playerMovement.isGrounded = false;
        //}
    }
}
