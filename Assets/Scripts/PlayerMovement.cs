using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] CharacterController player;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpHeight = 5f;
    //float velocity;
    float gravity = 1f;
    float yVelocity;

    //public bool isGrounded = true;
    //float maxSpeed = 30f;
    //float acceleration = 2f;

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


        //Jump
        if (player.isGrounded)
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
            yVelocity -= gravity;
        }

        velocity.y = yVelocity;
        player.Move(velocity * Time.deltaTime);
    }
}
