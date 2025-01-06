using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    [SerializeField] private float rotationAmt = 15f;
    [SerializeField] private int Health = 10;

    //Getters and Setters
    public float GetMoveSpeed() { return moveSpeed; }
    public void SetMoveSpeed(float moveSpeed) { moveSpeed = moveSpeed; }
    public float GetRotationAmt() { return rotationAmt; }
    public void SetRotationAmt(float rotationAmt) { rotationAmt = rotationAmt; }
    public int GetHealth() { return Health; }
    public void SetHealth(int Health) { Health = Health; }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Forwards");
            transform.position += transform.up * Time.deltaTime * moveSpeed;
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z - rotationAmt);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(transform.rotation.x, transform.rotation.y, transform.rotation.z + rotationAmt);
        }
    }
}