using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    void Start()
    {
        GameObject tank = Instantiate(player, player.transform.position, player.transform.rotation);
        GameObject badguy = Instantiate(enemy, enemy.transform.position, enemy.transform.rotation);
    }


    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

}
