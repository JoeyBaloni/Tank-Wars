using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missile : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = (transform.up * speed); 
    }

    private void OnCollisionEnter (Collision collision)
    {
    	if (collision.gameObject.CompareTag("destroyer"))
        { 
		    Destroy (gameObject);
	    }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<enemy>().EnemyDeath();
            Destroy(gameObject);
        }
    }
}
