using System;
using UnityEngine;
using UnityEngine.UI;

public class tankcontroller : MonoBehaviour
{
    public Transform tank;
    public GameObject enemy;
    public float gridDist;
    public int moveCount;

    public bool canTurnRight;
    public bool canTurnLeft;
    public bool canMoveForward;
    public bool canMoveBack;
    public bool myTurn;
    public bool win;
    public bool lose;


    void Start()
    {
        myTurn = true;
        canTurnRight = true;
        canTurnLeft = true;
        canMoveForward = true;
        canMoveBack = true;
        gridDist = 12;
        moveCount = 3;
    }

    void Update()
    {
        if(Input.GetKeyUp("space"))
        {
            myTurn = false;
            enemy.GetComponent<EnemyController>().enemyTurn();
        }

        if(myTurn == true)
        {
            if(Input.GetAxisRaw("Horizontal") == 1f && canTurnRight) 
            {
                transform.RotateAround(transform.position, Vector3.up, 45);
                canTurnRight = false;
            }
            else if (Input.GetAxisRaw("Horizontal") == 0f)
            {
                canTurnRight = true;
            }

            if(Input.GetAxisRaw("Horizontal") == -1f && canTurnLeft) 
            {
                transform.RotateAround(transform.position, Vector3.up, -45);
                canTurnLeft = false;
            }
            else if (Input.GetAxisRaw("Horizontal") == 0f)
            {
                canTurnLeft = true;
            }
            

            if(Input.GetAxisRaw("Vertical") == 1f && canMoveForward && moveCount > 0) 
            {
                //Checks for diagonal movement, and then moves slightly further for 45degree angles
                switch (Math.Round(transform.rotation.eulerAngles.y))
                {
                    case 0:
                    case 90:
                    case 180:
                    case 270:
                        transform.Translate(0f, 0f, gridDist);
                    break;
                    case 45:
                    case 135:
                    case 225:
                    case 315:
                        transform.Translate(0f, 0f,(float)Math.Sqrt(Math.Pow(gridDist,2) + Math.Pow(gridDist,2)));
                    break;
                }
                moveCount --;
                canMoveForward = false;
            }

            else if (Input.GetAxisRaw("Vertical") == 0f){
                canMoveForward = true;
            }

            if(Input.GetAxisRaw("Vertical") == -1f && canMoveBack && moveCount > 0) 
            {
                switch (Math.Round(transform.rotation.eulerAngles.y))
                {
                    case 0:
                    case 90:
                    case 180:
                    case 270:
                        transform.Translate(0f, 0f, -gridDist);
                    break;
                    case 45:
                    case 135:
                    case 225:
                    case 315:
                        transform.Translate(0f, 0f,-(float)Math.Sqrt(Math.Pow(gridDist,2) + Math.Pow(gridDist,2)));
                    break;
                }

                canMoveBack = false;
                moveCount --;
            }

            else if (Input.GetAxisRaw("Vertical") == 0f){
                canMoveBack = true;
            }
        }

        if (myTurn == false) // at this point, the enemy has made their moves and it is now myTurn again
        {
            Debug.Log("It's my turn!");
            myTurn = true;
            moveCount = 3;
        }
        
    }

}
