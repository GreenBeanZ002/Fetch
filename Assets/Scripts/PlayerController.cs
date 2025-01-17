using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 50f;
    private Rigidbody2D rb;
    private bool startBool;
 

    //Getters and Setters

    public bool GetStart() { return startBool; }
    public void SetStart(bool startTemp) { startBool = startTemp; }


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
            Debug.Log("H" + h.ToString() + "V" + v.ToString());
            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * moveSpeed * Time.deltaTime;
            rb.MovePosition(rb.transform.position + tempVect);

            foreach (var gObj in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(gObj);
            }
        }
    }
}
