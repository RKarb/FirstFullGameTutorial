using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawning : MonoBehaviour
{
    void Start()
    {
        GlobalCoins.coinCount = 0;
        SceneManager.LoadScene(GlobalLevel.levelNumber);
    }

}
