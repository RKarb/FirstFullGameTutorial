using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 1.5f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) // Checking for A key input every frame
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed); // If input is detected object moves left in real time at set movespeed
        }
        if (Input.GetKey(KeyCode.D)) // Checking for D key input every frame
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed * -1); // If input is detected object moves right in real time at set movespeed
        }
        if (Input.GetKey(KeyCode.W)) // Checking for W key input every frame
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed); // If input is detected object moves forward in real time at set movespeed
        }
        if (Input.GetKey(KeyCode.S)) // Checking for W key input every frame
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * -1); // If input is detected object moves forward in real time at set movespeed
        }
    }
}
