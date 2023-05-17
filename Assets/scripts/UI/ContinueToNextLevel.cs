using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToNextLevel : MonoBehaviour
{
    public void NextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneNum = currentScene.buildIndex;

        SceneManager.LoadSceneAsync(sceneNum + 1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(currentScene);
        SceneManager.UnloadSceneAsync("WinScene");
    }
}
