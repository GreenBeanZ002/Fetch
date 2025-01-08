using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    public Rigidbody2D rb;
    private bool testBool = false;
 

    //Getters and Setters
    public float GetMoveSpeed() { return moveSpeed; }
    public void SetMoveSpeed(float moveSpeed) { moveSpeed = moveSpeed; }



    // Update is called once per frame
    void FixedUpdate()
    {
        if (testBool)
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.transform.position + tempVect);
        }
    }
}
