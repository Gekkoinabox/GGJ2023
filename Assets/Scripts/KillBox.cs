using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBox : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject player;
    GameObject gm;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindWithTag("Player");
        gm = GameObject.FindWithTag("GameManager");
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            //Collided with player so kill them
            //Get player
            player.SetActive(false);
            player.transform.position = spawnPoint.position;
            player.SetActive(true);
            gm.GetComponent<GameManager>().playerHealth--;
        }
    }
}
