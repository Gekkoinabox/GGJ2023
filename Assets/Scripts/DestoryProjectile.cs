using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryProjectile : MonoBehaviour
{
    [SerializeField]
    float projectileLifeSpan = 5;

    // starts coroutine 'timer'
    private void Start()
    {
        StartCoroutine(DestroySelf());
    }

    // method to self destruct
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(3f);
        Destroy(this.gameObject);
    }

    // destroys self on collision
    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(this.gameObject);
    }
}
