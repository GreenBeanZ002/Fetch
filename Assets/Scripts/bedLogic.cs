using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bedLogic : PlayerController
{

    [SerializeField] private Canvas winUI;
    [SerializeField] private TMP_Text winTxt;
    private GameObject wonCheck;

    private void Start()
    {
        winUI.enabled = false;
    }
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            wonCheck = GameObject.FindWithTag("Ball");
            if (wonCheck != null)
                Debug.Log("Result" + GetGotBall());

            {
                winUI.enabled = true;
                winTxt.text = "You need to get the ball.";
                
            }
            if (wonCheck == null)
            {
                {
                    winUI.enabled = true;
                    winTxt.text = "You won!";
                }

            }
        }
    }
}
