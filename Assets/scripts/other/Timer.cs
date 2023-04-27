using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text gameOverText;
    private float startTime;
    private float totalTime = 10.0f;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float timeLeft = totalTime - (Time.time - startTime);
        if (timeLeft < 0.0f)
        {
            timeLeft = 0.0f;
            Time.timeScale = 0.0f; // Freeze the game
            gameOverText.text = "Game Over"; // Show the "Game Over" message
        }
        else
        {
            string minutes = ((int)timeLeft / 60).ToString();
            string seconds = (timeLeft % 60).ToString("f2");
            timerText.text = minutes + ":" + seconds;
        }
    }
}