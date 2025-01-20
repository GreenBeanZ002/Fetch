using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballColourController : MonoBehaviour
{
    public int ballColor = 1; 
    [SerializeField] private GameObject ball;
    [SerializeField] private Sprite ball1;
    [SerializeField] private Sprite ball2;
    [SerializeField] private Sprite ball3;
    [SerializeField] private Sprite ball4;

    public int GetBallColour () { return ballColor; }
    public void SetBallColor (int ballAmt) { ballColor = ballAmt; }
    void Update()
    {
        switch (ballColor)
        {
        //state machine which swaps the ball's sprite based on the value of the "BallColour" integer.
            case 1:
                ball.GetComponent<SpriteRenderer>().sprite = ball1; 
                break;
            case 2:
                ball.GetComponent<SpriteRenderer>().sprite = ball2;
                break;
            case 3:
                ball.GetComponent<SpriteRenderer>().sprite = ball3;
                break; 
            case 4:
                ball.GetComponent<SpriteRenderer>().sprite = ball4;
                break; 
        }
    }
}
