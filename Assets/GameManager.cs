using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;
    public Text ammoText;
    public static GameManager gameManager;

    public Transform target;

    public GameObject enemy;
    public Transform[] spawnpoints = new Transform[3];

    private void Awake()
    {
        gameManager = this;
    }
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 1f);
    }
    public void UpdateText ()
    {
       ammoText.text = "Ammo"+ playerController.ammo.ToString();
    }

    public void SpawnEnemy()
    {
        int index = Random.Range(0, 3);
        Instantiate(enemy, spawnpoints[index].position, transform.rotation);
    }

}
