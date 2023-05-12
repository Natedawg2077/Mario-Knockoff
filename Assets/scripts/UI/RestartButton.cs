using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void Restart()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if(sceneName != "Paused")
        {
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene(sceneName);
            SceneManager.LoadScene("InLevel", LoadSceneMode.Additive);
            if(sceneName == "Paused")
            {
                SceneManager.UnloadSceneAsync("Paused");
            }
            Time.timeScale = 1;
        }

    }
}
