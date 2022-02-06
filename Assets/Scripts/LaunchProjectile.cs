using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 2000f;
    public bool fireTime;

    void Start()
    {
        fireTime = false;
    }

    void Update()
    {
        if (Input.GetKeyUp("space"))
        {
            GameObject bullet = Instantiate(projectile, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchVelocity, 0));
            fireTime = false;
        }
    }
}
