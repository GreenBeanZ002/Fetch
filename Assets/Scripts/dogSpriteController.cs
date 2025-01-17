using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpriteController : MonoBehaviour
{
    [SerializeField] private GameObject dog;
    [SerializeField] private Sprite dog_v1_up;
    [SerializeField] private Sprite dog_v1_down;
    [SerializeField] private Sprite dog_v1_left;
    [SerializeField] private Sprite dog_v1_right;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        switch (h)
        {
            case < 0:
                switch (v) 
                {
                    case < 0:
                        break;
                    case > 0:
                        break;
                    case 0:
                        break;
                }
                break;
            case > 0:
                switch (v) 
                {
                    case < 0:
                        break;
                    case > 0:
                        break;
                    case 0:
                        break;
                }
                break;

            case 0:
                switch (v)
                {
                    case < 0:
                        break;
                    case > 0:
                        break;
                    case 0:
                        break;
                }
                break;

        }
    }
}
