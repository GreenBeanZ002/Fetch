using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] private float rotationAmt = 15f;
    [SerializeField] private int Health = 10;
    public Rigidbody2D rb;

    //Getters and Setters
    public float GetMoveSpeed() { return moveSpeed; }
    public void SetMoveSpeed(float moveSpeed) { moveSpeed = moveSpeed; }
    public float GetRotationAmt() { return rotationAmt; }
    public void SetRotationAmt(float rotationAmt) { rotationAmt = rotationAmt; }
    public int GetHealth() { return Health; }
    public void SetHealth(int Health) { Health = Health; }


    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }
}
