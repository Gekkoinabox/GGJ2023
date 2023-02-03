using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] CharacterController player;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float speed = 5f;
    bool isGrounded = true;
    //float maxSpeed = 30f;
    //float acceleration = 2f;

    // Update is called once per frame
    void Update()
    {
        //User input
        if (Input.GetKey(KeyCode.D))
        {
            //Move right
            player.Move(new Vector3(speed, 0, 0) * Time.deltaTime);
        }
        //Check for A key
        if (Input.GetKey(KeyCode.A))
        {
            //Move Left
            player.Move(new Vector3(-speed, 0, 0) * Time.deltaTime);
        }
        //Jump
        if (Input.GetKeyDown(KeyCode.W))
        {
            isGrounded = false;
        } 
    }
}
