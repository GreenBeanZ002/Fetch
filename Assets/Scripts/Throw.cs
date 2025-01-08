using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Runtime.CompilerServices.RuntimeHelpers;

public class Throw : MonoBehaviour
{
    private bool GameStart;

    public bool GetGameStart() { return GameStart; }
    public void SetGameStart(bool GameStart) { GameStart = GameStart; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space Pressed");

        }

    }
}
