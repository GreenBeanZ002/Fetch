using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;


public class Throw : PlayerController
{
    [SerializeField] private Canvas togglePrompt;


    // Start is called before the first frame update
    void Start()
    {
        togglePrompt.enabled = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SetStart(true);
            Debug.Log("Space Pressed");
            togglePrompt.enabled = false;
        }

    }
    private void FixedUpdate()
    {
        
    }
}
