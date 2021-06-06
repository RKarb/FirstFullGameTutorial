using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTime : MonoBehaviour
{

    public GameObject timeDisplay;
    public int seconds = 30;
    public bool deductingTime;

    void Update()
    {
        if (deductingTime == false)
        {
            deductingTime = true;
            StartCoroutine(DeductSecond());
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
