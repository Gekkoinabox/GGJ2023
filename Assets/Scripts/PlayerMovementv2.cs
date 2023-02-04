using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovementv2 : MonoBehaviour 
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    int direction;
    GameObject spawn;
    

    // Start is called before the first frame update
    void Start()
    {
        spawn = GameObject.FindGameObjectWithTag("SpawnPoint");
        transform.position = spawn.transform.position;
        direction = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump= true;
        }
    }

    private void FixedUpdate()
    {
        //move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        if (Input.GetKey(KeyCode.A))
        {
            //Facing left
            direction = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            //Facing Right
            direction = 1;
        }
        jump = false;
    }

    public int GetDirection()
    {
        return direction;
    }
}
