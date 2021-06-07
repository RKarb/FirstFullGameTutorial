using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }
        
    public void LoadGame()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
