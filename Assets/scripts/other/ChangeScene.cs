using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToScene(int sceneID)
    {
        //Loads into the selected level, then also loads the menu button
        SceneManager.LoadScene(sceneID);
        SceneManager.LoadScene("InLevel", LoadSceneMode.Additive);
    }
}
