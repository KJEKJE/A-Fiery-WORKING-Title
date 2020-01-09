using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootMechanic : MonoBehaviour
{
    public GameObject pewPrefab;
    public Transform pewSpawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;

    AudioSource whatsfx;

    private void Start()
    {
        whatsfx = GetComponent<AudioSource>();
    }

    private void SetFiring()
    {
        isFiring = false;
    }
    private void Fire()
    {

        isFiring = true;
        Instantiate(pewPrefab, pewSpawn.position, pewSpawn.rotation);
        if (GetComponent<AudioSource>() != null)//checks for an audio clip. see 2c for more
        {
            GetComponent<AudioSource>().Play();
        }
        Invoke("SetFiring", fireTime);
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }
}
