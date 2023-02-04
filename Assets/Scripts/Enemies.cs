using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    [SerializeField]
    int enemyHealth = 2;
    public GameManager gM;

    private void Update()
    {
        // kills enenmy game object when enemy's health is 0
        if (enemyHealth == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gM.playerHealth = gM.playerHealth - 1;
        }

        if (other.gameObject.tag == "Projectile")
        {
            enemyHealth = enemyHealth - 1;
        }
    }
}
