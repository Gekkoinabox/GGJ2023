using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public bool movingLeft = true;
    public bool goRight;
    public Transform groundDetection;

    void Update()
    {
        if (goRight == true) // if the goRight box if checked
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime); // make the enemy go right
        }
        else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime); // if not then go left
        }

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 1f); // so the enemy stays on the ground

        if (groundInfo.collider == false) // if the enemy groundinfo collider is not touching the ground
        {
            if (movingLeft == true) // if the enemy is going left
            {
                transform.eulerAngles = new Vector3(0, -180, 0); // make the enemy go right
                movingLeft = false; // make this boolean false
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0); // make the enemy go left
                movingLeft = true; // make this boolean true
            }
        }
    }
}