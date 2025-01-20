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
    public void ChooseBreed()
    {

    }
    public void ChooseBall()
    {

    }
    public void ChooseBed()
    {

    }
}
