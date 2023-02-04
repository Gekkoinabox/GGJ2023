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
        // kills enenmy game object
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
            //Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Projectile")
        {
            enemyHealth = enemyHealth - 1;
        }
    }
}
