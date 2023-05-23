using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToNextLevel : MonoBehaviour
{
    // !!!!  Needs to be changed and increased if a scene is added to the build settings so that these variables are the number of the first level !!!!
    public int startLevelScenes = 5;
    public int levelScenes = 5;

    public void NextLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int sceneNum = currentScene.buildIndex;

        for(int i = SceneManager.sceneCountInBuildSettings - startLevelScenes; i > 0; i--)
        {
            
            if (sceneNum == levelScenes)
            SceneManager.UnloadSceneAsync(levelScenes);
            levelScenes++;
        }

        SceneManager.LoadScene("InLevel");
        SceneManager.LoadScene(sceneNum + 1, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("WinScene");
    }
}
