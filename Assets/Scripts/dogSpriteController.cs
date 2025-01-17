using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpriteController : MonoBehaviour
{
    public int dogBreed = 1; 
    [SerializeField] private GameObject dog;
    [SerializeField] private Sprite dog_v1_up;
    [SerializeField] private Sprite dog_v1_down;
    [SerializeField] private Sprite dog_v1_left;
    [SerializeField] private Sprite dog_v1_right;
    [SerializeField] private Sprite dog_v1_idle; 
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
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_up;
                        break;
                    case > 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_down;
                        break;
                    case 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_left;
                        break;

                }
                break;
            case > 0:
                switch (v) 
                {
                    case < 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_up;
                        break;
                    case > 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_down;
                        break;
                    case 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_right;
                        break;
                        
                }
                break;

            case 0:
                switch (v)
                {
                    case < 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_left;
                        break;
                    case > 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_right;
                        break;
                    case 0:
                        dog.GetComponent<SpriteRenderer>().sprite = dog_v1_idle;
                        break;
                        
                }
                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_idle;
                break;

        }
    }
}
