using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject explosion;
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosion, transform.position, transform.rotation);
        if (collision.gameObject.CompareTag("Missle"))
            Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
