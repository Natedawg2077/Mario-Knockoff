using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    public Text text; // Reference to the text UI component in the Inspector

    void Start()
    {
        text.text = ""; // Set the initial text to be empty
    }

    private void OnTriggerEnter2D(Collider2D other) // Use "Collider2D" instead of "Collider" for 2D games
    {
        if (other.CompareTag("Player")) // Replace "Player" with the tag of your player object
        {
            text.text = "Level Completed"; // Set the text to be displayed
            Debug.Log("touched me");
        }
    }
}
