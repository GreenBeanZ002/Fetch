using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
            foreach (var gObj in GameObject.FindGameObjectsWithTag("Line"))
            {
                Destroy(gObj);
            }


            var gameObj = new GameObject();
            gameObj.tag = "Line";
            var lineRend = gameObj.AddComponent<LineRenderer>();
            lineRend.SetPosition(0, Dog.transform.position);
            lineRend.SetPosition(1, Ball.transform.position);
            lineRend.material.SetColor("_Color", Color.green);

        }
    }
}
