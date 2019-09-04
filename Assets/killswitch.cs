using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killswitch : MonoBehaviour
{
    public GameObject loseMessage;
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Endgame();
        }
    }
    public void Endgame()
    {
        Time.timeScale = 0;
        loseMessage.SetActive(true);
    }
}
