using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform enemy;
    public LaunchProjectile launchBoy;

    void Start()
    {
        GameObject origin = GameObject.FindGameObjectWithTag("LaunchOrigin");
        launchBoy = origin.GetComponent<LaunchProjectile>();
    }
    public void enemyTurn()
    {
        Debug.Log("The Enemy is Moving!! HEHEHE!");
        enemy.rotation = Quaternion.Euler(0, 90, 0);  // use Random.Range
        launchBoy.fireTime = true;
        
    }
}
