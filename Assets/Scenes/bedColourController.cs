using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedColourController : MonoBehaviour
{
    public int bedColor = 1; 

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
                //change bed colour to green
                break;
            case 2:
                //change bed colour to yellow
                break;
            case 3:
                //change bed colour to red
                break; 
            case 4:
                //change bed colour to blue
                break; 
        }
    }
}
