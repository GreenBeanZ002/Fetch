using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniff : MonoBehaviour
{
    [SerializeField] private GameObject Dog;
    [SerializeField] private GameObject Ball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            var gameObj = new GameObject();
            var lineRend = gameObj.AddComponent<LineRenderer>();
            lineRend.SetPosition(0, Dog.transform.position);
            lineRend.SetPosition(1, Ball.transform.position);

            gameObj = null;
        }
    }
}
