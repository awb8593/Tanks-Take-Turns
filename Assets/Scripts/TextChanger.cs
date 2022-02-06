using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    public tankcontroller Tank;
    public Text moves;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("moves");
        Tank = player.GetComponent<tankcontroller>();
    }

    void Update()
    {
        moves.text = "Moves: " + Tank.moveCount;
    }
}
