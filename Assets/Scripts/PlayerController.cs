using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro; 

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    private Rigidbody2D rb;
    private bool startBool;
    private bool gotBall;
 

    //Getters and Setters

    public bool GetStart() { return startBool; }
    public void SetStart(bool startTemp) { startBool = startTemp; }

    public bool GetGotBall() {  return gotBall; }
    public void SetGotBall(bool ball) { gotBall = ball; }


    void Start()
    {
        startBool = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GetStart() == false)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.transform.position + tempVect);

            //clearing bits left by other scripts. 
            foreach (var gObj in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(gObj);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ball")
        {
            Destroy(collision.gameObject);
            SetGotBall(true);
            Debug.Log("Got ball");
        }
    }
}
