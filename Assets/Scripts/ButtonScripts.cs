using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] private Canvas Settings;
    [SerializeField] private Canvas Help;
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
    }
    public void closeSettings() 
    {
        Settings.enabled = false;
    }

    public void openHelp()
    {
        Help.enabled = true;
    }
    public void closeHelp()
    {
        Help.enabled = false;
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
