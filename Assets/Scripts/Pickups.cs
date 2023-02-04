using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public GameManager gameManager;

    // collision with pickup logic
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManager.playerScore = gameManager.playerScore + 300;
            Destroy(this.gameObject);
        }
    }
}
