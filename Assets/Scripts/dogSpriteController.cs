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
    [SerializeField] private Sprite dog_v2_up;
    [SerializeField] private Sprite dog_v2_down;
    [SerializeField] private Sprite dog_v2_left;
    [SerializeField] private Sprite dog_v2_right;
    [SerializeField] private Sprite dog_v2_idle;
    [SerializeField] private Sprite dog_v3_up;
    [SerializeField] private Sprite dog_v3_down;
    [SerializeField] private Sprite dog_v3_left;
    [SerializeField] private Sprite dog_v3_right;
    [SerializeField] private Sprite dog_v3_idle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        switch (dogBreed)
        {
            case 1:
                switch (h)
                {
                    case < 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_up;
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
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_up;
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
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v1_idle;
                                break;

                        }
                        break;



                }
                break;
            case 2:
                switch (h)
                {
                    case < 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_left;
                                break;

                        }
                        break;
                    case > 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_right;
                                break;

                        }
                        break;

                    case 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v2_idle;
                                break;

                        }
                        break;



                }
                break;
            case 3:
                switch (h)
                {
                    case < 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_left;
                                break;

                        }
                        break;
                    case > 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_right;
                                break;

                        }
                        break;

                    case 0:
                        switch (v)
                        {
                            case < 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_down;
                                break;
                            case > 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_up;
                                break;
                            case 0:
                                dog.GetComponent<SpriteRenderer>().sprite = dog_v3_idle;
                                break;

                        }
                        break;



                }
                break;


        }
    }
}
