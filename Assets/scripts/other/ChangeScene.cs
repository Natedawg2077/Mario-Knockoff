using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToScene(string sceneName)
    {
        //Loads into the selected level, then also loads the menu button
        SceneManager.LoadScene(sceneName);
        SceneManager.LoadScene("InLevel", LoadSceneMode.Additive);
    }
}
