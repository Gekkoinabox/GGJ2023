using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField]
    int enemyHealth = 2;

    public GameManager gM;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("damage collision");
            gM.playerHealth = gM.playerHealth - 1;
            //Destroy(this.gameObject);
        }
    }
}
