using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public void LoadPauseMenu()
    {
        //Loads the pause menu scene and unloads the InLevel(this scene) scene used for UI
        SceneManager.LoadScene("Paused", LoadSceneMode.Additive);
        Time.timeScale = 0.0f;
        SceneManager.UnloadSceneAsync("InLevel");
    }
}
