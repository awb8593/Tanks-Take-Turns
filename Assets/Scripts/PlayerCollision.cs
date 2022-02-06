using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "bullet(Clone)" || col.gameObject.name == "enemy(Clone)")
        {
            Debug.Log("You LOSE!");
            Destroy(gameObject);
        }
    }
}
