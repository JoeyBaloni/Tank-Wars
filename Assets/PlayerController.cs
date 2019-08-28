using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turretRotation;
    public float gunRotation;

    public Vector2 rotation = new Vector2(0, 0);
    public float rotspeed = 6;

    public GameObject turret;
    public GameObject camera;
    public GameObject barrel;

    public Rigidbody rb;
    public float speed;
    public float rotationSpeed;
    public float fireRate = 0.25f;
    private float nextFire;
    public GameObject missile;
    public Transform shotspawn;
    public int ammo = 100;

    public ParticleSystem muzzleFlash;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire && ammo > 0 )
        {
            muzzleFlash.Play();
            Instantiate(missile, shotspawn.position, shotspawn.rotation);
            nextFire = Time.time + fireRate;
            ammo -= 1;
            GameManager.gameManager.UpdateText();
        }



        
        rotation.y += Input.GetAxis("Mouse X");
        //camera.transform.eulerAngles = rotation * rotspeed;
       // barrel.transform.eulerAngles = rotation * rotspeed;
        rotation.x -= Input.GetAxis("Mouse Y");
        rotation.x = 0;
        turret.transform.eulerAngles = rotation * rotspeed;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.up * rotationSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(transform.up * -rotationSpeed);
        }

    }







}
