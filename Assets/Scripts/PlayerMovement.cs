using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] CharacterController player;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpHeight = 5f;
    [SerializeField] BoxCollider2D boxCollider;
    bool isGrounded;
    //float velocity;
    float gravity = 1f;
    float yVelocity;

    //public bool isGrounded = true;
    //float maxSpeed = 30f;
    //float acceleration = 2f;

    void Start()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(horizontalInput, 0, 0);
        Vector3 velocity = direction * speed;


        ////User input
        //if (Input.GetKey(KeyCode.D))
        //{
        //    //Move right
        //    player.Move(new Vector3(speed, 0, 0) * Time.deltaTime);
        //}

        ////Check for A key
        //if (Input.GetKey(KeyCode.A))
        //{
        //    //Move Left
        //    player.Move(new Vector3(-speed, 0, 0) * Time.deltaTime);
        //}
        
        ////Store all collisions into an array
        //Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxCollider.size, 0);

        ////Check if on floor
        //foreach(Collider2D hit in hits)
        //{
        //    if(hit == boxCollider)
        //    {
        //        continue;
        //    }

        //    ColliderDistance2D colliderDistance = hit.Distance(boxCollider);

        //    if(colliderDistance.isOverlapped)
        //    {
        //        transform.Translate(colliderDistance.pointA - colliderDistance.pointB);
        //    }
        //}

        //check if the player is touching the ground with a ray
        //create ray
        

        //Jump
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpHeight;
            }

            //player.Move(new Vector3(0, transform.position.y, 0) * Time.deltaTime);
            //isGrounded = false;
        } 
        else
        {
            //yVelocity -= gravity;
        }

        velocity.y = yVelocity;
        player.Move(velocity * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.up, 1f);

        if (hit.collider != null)
        {
            //check if we hit the ground
            if (hit.collider.tag == "Ground")
            {
                isGrounded = true;
                Debug.Log("ground has been hit");
            }
            else
            {
                isGrounded = false;
            }
        }
    }
}
