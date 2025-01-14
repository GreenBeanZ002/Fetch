using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class Throw : PlayerController
{
    [SerializeField] private Canvas togglePrompt;
    private Rigidbody2D Rb; 


    // Start is called before the first frame update
    void Start()
    {
        togglePrompt.enabled = true;

        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Vector2 direction = new Vector2((float)Random.Range(-1000, 1000), (float)Random.Range(-1000, 1000));

            float force = (float)Random.Range(-1000, 1000);
            Rb.AddForce(direction * force);
            SetStart(true);
            Debug.Log("Space Pressed");
            togglePrompt.enabled = false;
        }

    }
    private void FixedUpdate()
    {
        
    }
}
