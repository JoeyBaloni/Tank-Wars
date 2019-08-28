using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killswitch : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(player);
        }
    }
}
