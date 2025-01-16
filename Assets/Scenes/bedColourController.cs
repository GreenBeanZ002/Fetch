using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedColourController : MonoBehaviour
{
    public int bedColor = 1; 
    [SerializeField] private GameObject bed;
    [SerializeField] private Sprite bed1;
    [SerializeField] private Sprite bed2;
    [SerializeField] private Sprite bed3;
    [SerializeField] private Sprite bed4;

    public int GetBedColour () { return bedColor; }
    public void SetBedColor (int bedAmt) { bedColor = bedAmt; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (bedColor)
        {
            case 1:
                bed.GetComponent<SpriteRenderer>().sprite = bed1; 
                break;
            case 2:
                bed.GetComponent<SpriteRenderer>().sprite = bed2;
                break;
            case 3:
                bed.GetComponent<SpriteRenderer>().sprite = bed3;
                break; 
            case 4:
                bed.GetComponent<SpriteRenderer>().sprite = bed4;
                break; 
        }
    }
}
