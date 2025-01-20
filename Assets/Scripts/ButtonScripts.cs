using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
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

    }
    public void closeSettings() 
    {
    
    }

    public void openHelp()
    {

    }
    public void closeHelp()
    {

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
