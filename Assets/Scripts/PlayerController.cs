using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] private float rotationAmt = 15f;
    [SerializeField] private int Health = 10;
    private Rigidbody2D rb;

    //Getters and Setters
    public float GetMoveSpeed() { return moveSpeed; }
    public void SetMoveSpeed(float moveSpeed) { moveSpeed = moveSpeed; }
    public float GetRotationAmt() { return rotationAmt; }
    public void SetRotationAmt(float rotationAmt) { rotationAmt = rotationAmt; }
    public int GetHealth() { return Health; }
    public void SetHealth(int Health) { Health = Health; }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Forwards");
            transform.position += transform.up * Time.deltaTime * moveSpeed;
        }
    }
}
