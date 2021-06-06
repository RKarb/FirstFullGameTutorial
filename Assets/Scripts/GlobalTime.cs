using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalTime : MonoBehaviour
{

    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;

    void Update()
    {
        if (seconds == 0)
        {
            seconds = 0;
            SceneManager.LoadScene(1);
        }
        else
        {
            if (deductingTime == false)
            {
                deductingTime = true;
                StartCoroutine(DeductSecond());
            }
        }
    }

    IEnumerator DeductSecond()
    {
        yield return new WaitForSeconds(1);
        seconds -= 1;
        timeDisplay.GetComponent<Text>().text = "TIME: " + seconds;
        deductingTime = false;
    }
}
