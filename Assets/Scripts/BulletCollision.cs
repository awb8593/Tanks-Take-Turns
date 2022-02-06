using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
        if (col.gameObject.name == "player(Clone)")
        {
            print("You LOSE!");
        }
    }
}
