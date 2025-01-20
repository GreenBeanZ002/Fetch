using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] private Canvas Settings;
    [SerializeField] private Canvas HUD;
    [SerializeField] private Canvas Help;
    private int BreedIncrement;
    private int BallIncrement;
    private int BedIncrement;
    private int MaxBreedIncrement = 3;
    private int MaxBallIncrement = 4;
    private int MaxBedIncrement = 4; 


    public dogSpriteController dogSpriteController;
    public bedColourController BedColourController;
    public ballColourController BallColourController;
    public void replayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void mainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void openSettings()
    {
        Settings.enabled = true;
        HUD.enabled = false;

    }
    public void closeSettings() 
    {
        Settings.enabled = false;
        HUD.enabled = true; 
    }

    public void openHelp()
    {
        Help.enabled = true;
        HUD.enabled = false;
    }
    public void closeHelp()
    {
        Help.enabled = false;
        HUD.enabled = true;
    }
    public void ChooseBreedNext()
    {
        if (BreedIncrement < MaxBreedIncrement)
        {
            BreedIncrement++;
        }
        else 
        {
            BreedIncrement = 1;
        }
        dogSpriteController.dogBreed = BreedIncrement; 
    }
    public void ChooseBreedBack()
    {
        if (BreedIncrement > 1)
        {   
            BreedIncrement--;   
        }
        else
        {
            BreedIncrement = MaxBreedIncrement;
        }
        dogSpriteController.dogBreed = BreedIncrement;
    }
    public void ChooseBallNext()
    {
        if (BallIncrement < MaxBallIncrement)
        {
            BallIncrement++;
        }
        else
        {
            BallIncrement = 1;
        }
        BallColourController.ballColor = BallIncrement;
    }
    public void ChooseBallBack()
    {
        if(BallIncrement > 1)
        {
            BallIncrement--;
        }
        else
        {
            BallIncrement = MaxBallIncrement;
        }
        BallColourController.ballColor = BallIncrement;
    }

    public void ChooseBedNext()
    {
        if (BedIncrement < MaxBedIncrement)
        {
            BedIncrement++;
        }
        else
        {
            BedIncrement = 1;
        }
        BedColourController.bedColor = BedIncrement;
    }
    public void ChooseBedBack()
    {
        if (BedIncrement > 1)
        {
            BedIncrement--;
        }
        else
        {
            BedIncrement = MaxBedIncrement;
        }
        BedColourController.bedColor = BedIncrement;
    }
}
