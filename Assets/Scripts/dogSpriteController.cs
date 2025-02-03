using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpriteController : MonoBehaviour
{
    public int dogBreed = 1;
    public Animator anim;
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

           switch (h)
        {
            //A state machine which switches the player's current sprite based on the direction of their movement. It does this for 3 different varieties of the dog. 
            case < 0:
                switch (v)
                {
                    case < 0:
                        Down();
                        break;
                    case > 0:
                        Up();
                        break;
                    case 0:
                        Left();
                        break;

                }
                break;
            case > 0:
                switch (v)
                {
                    case < 0:
                        Down();
                        break;
                    case > 0:
                        Up();
                        break;
                    case 0:
                        Right();
                        break;

                }
                break;

            case 0:
                switch (v)
                {
                    case < 0:
                        Down();
                        break;
                    case > 0:
                        Up();
                        break;
                    case 0:
                        Idle();
                        break;

                }
                break;



        


        }
    }
    void Up()
    {
        anim.SetBool("Down", false);
        anim.SetBool("Up", true);
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
    }
    void Down() 
    {
        anim.SetBool("Down", true);
        anim.SetBool("Up", false);
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
    }   
    void Right()
    {
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Right", true);
        anim.SetBool("Left", false);
    }
    void Left()
    {
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Right", false);
        anim.SetBool("Left", true);
    }
    void Idle()
    {
        anim.SetBool("Down", false);
        anim.SetBool("Up", false);
        anim.SetBool("Right", false);
        anim.SetBool("Left", false);
    }
}
