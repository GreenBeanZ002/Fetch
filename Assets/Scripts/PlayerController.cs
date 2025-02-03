using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Canvas togglePrompt;
    [SerializeField] private float moveSpeed = 50f;
    private Rigidbody2D rb;
    private bool gotBall;


    //Getters and Setters

    public bool GetGotBall() { return gotBall; }
    public void SetGotBall(bool ball) { gotBall = ball; }


    void Start()
    { 
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //moves player if the toggle prompt screen isn't active.
        if (togglePrompt.enabled != true)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
            try
            {
                rb.MovePosition(rb.transform.position + tempVect);
            }
            catch
            {
                //gets rid of dumb errors which do nothing but cause me pain
            }
            

            //clearing bits left by other scripts. 
            foreach (var gObj in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(gObj);
            }

            //clearing bits left by other scripts. 
            foreach (var gObj in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(gObj);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //"Destroys" ball on collision, picking it up.
        if (collision.collider.tag == "Ball")
        {
            Destroy(collision.gameObject);
            SetGotBall(true);
            Debug.Log("Got ball" + GetGotBall());
        }
    }
}