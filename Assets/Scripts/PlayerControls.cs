using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    public GameObject playerChicken;

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Checking for A key input every frame
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed); // If input is detected object moves left in real time at set movespeed
            playerChicken.transform.localRotation = Quaternion.Euler(0, 270, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.D)) // Checking for D key input every frame
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * -1); // If input is detected object moves right in real time at set movespeed
            playerChicken.transform.localRotation = Quaternion.Euler(0, 90, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.W)) // Checking for W key input every frame
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); // If input is detected object moves forward in real time at set movespeed
            playerChicken.transform.localRotation = Quaternion.Euler(0, 0, 0); // Rotates player model according to its direction of movement 
        } 
        if (Input.GetKey(KeyCode.S)) // Checking for S key input every frame
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -1); // If input is detected object moves backwards in real time at set movespeed
            playerChicken.transform.localRotation = Quaternion.Euler(0, 180, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) // Checking for both W and D key input every frame
        {
            playerChicken.transform.localRotation = Quaternion.Euler(0, 45, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) // Checking for both D and S key input every frame
        {
            playerChicken.transform.localRotation = Quaternion.Euler(0, 135, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A)) // Checking for both S and A key input every frame
        {
            playerChicken.transform.localRotation = Quaternion.Euler(0, 225, 0); // Rotates player model according to its direction of movement 
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) // Checking for both A and W key input every frame
        {
            playerChicken.transform.localRotation = Quaternion.Euler(0, 315, 0); // Rotates player model according to its direction of movement 
        }
    }
}
