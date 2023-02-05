using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Call win
        if(collision != null)
        {
            if(collision.tag == "Player")
            {
                //call win
                gm.GetComponent<GameManager>().SetWin(true);
            }
        }
    }
}
