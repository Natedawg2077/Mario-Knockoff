using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) // Use "Collider2D" instead of "Collider" for 2D games
    {
        if (other.CompareTag("Player")) // Replace "Player" with the tag of your player object
        {
            SceneManager.LoadScene("WinScene", LoadSceneMode.Additive);

            Scene currentScene = SceneManager.GetActiveScene();
            int sceneNum = currentScene.buildIndex;
            if (sceneNum == 1)
                SceneManager.UnloadSceneAsync("InLevel");

            Time.timeScale = 0.0f;
        }
    }
}
