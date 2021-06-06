using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public AudioSource collectFX;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")   // Checks if an object with the Player tag has collided with the object carrying this script
        {
            collectFX.Play();
            GlobalCoins.coinCount += 1; // Increments the coinCount variable inside the GlobalCoins script by 1
            this.gameObject.SetActive(false);   // Sets the current object carrying this script to inactive, making it invisible to the player
        }
    }
}
