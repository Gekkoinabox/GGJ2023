using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovementv2 : MonoBehaviour 
{
    public CharacterController2D controller;

    public float runSpeed = 40f;
    public Animator anim;
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
        if(jump == true)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetBool("IsWalking", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetBool("IsWalking", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("IsWalking", false);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("IsWalking", false);
        }


        //move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Facing left
            direction = 0;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Facing Right
            direction = 1;
            //anim.Play("ParsnipArms|WalkCycle", 0, 2f);
        }
        jump = false;
    }

    public int GetDirection()
    {
        return direction;
    }

}
