using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public void Unpause()
    {
        SceneManager.LoadScene("InLevel", LoadSceneMode.Additive);
        Time.timeScale = 1.0f;
        SceneManager.UnloadSceneAsync("Paused");
    }
}
