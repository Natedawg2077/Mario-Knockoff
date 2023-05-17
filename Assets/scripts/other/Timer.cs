using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public GameObject gameOverText;
    public GameObject player;
    public bool stillAlive = true;
    private float startTime;
    private float totalTime = 90.0f;

    void Start()
    {
        startTime = Time.time;
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (stillAlive)
        {
            float timeLeft = totalTime - (Time.time - startTime);
            if (timeLeft < 0.0f)
            {
                timeLeft = 0.0f;
                SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("InLevel");
                player = GameObject.FindWithTag("Player");
                gameOverText.GetComponent<Text>().text = "Too Slow!";
            }
            else
            {
                string minutes = ((int)timeLeft / 60).ToString();
                string seconds = (timeLeft % 60).ToString("f2");
                timerText.text = minutes + ":" + seconds;
            }
        }
    }
}