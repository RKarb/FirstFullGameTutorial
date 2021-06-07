using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public int loadLevel;
    public GameObject hintBox;
    public int hintNum;

    void Start()
    {
        hintNum = Random.Range(1,4);
        if(hintNum == 1)
        {
            hintBox.GetComponent<Text>().text = "Welcome to my first game, please enjoy!";
        }
        if (hintNum == 2)
        {
            hintBox.GetComponent<Text>().text = "Collect all coins to win!";
        }
        if (hintNum == 3)
        {
            hintBox.GetComponent<Text>().text = "Don't touch the spikes!";
        }
    }

    public void StartGame()
    {
        GlobalLevel.levelNumber = 3;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }
        
    public void LoadGame()
    {
        loadLevel = PlayerPrefs.GetInt("LevelLoadNum");
        if(loadLevel < 3)
        {
            SceneManager.LoadScene(GlobalLevel.levelNumber);
        }
        else
        {
            GlobalLevel.levelNumber = loadLevel;
            SceneManager.LoadScene(loadLevel);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
