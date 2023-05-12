using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text gameOverText;
    private float startTime;
<<<<<<< Updated upstream
    private float totalTime = 90.0f;
=======
    private float totalTime = 10.0f;
    private bool levelComplete = false;
>>>>>>> Stashed changes

    void Start()
    {
        startTime = Time.time;
    }
<<<<<<< Updated upstream

    void Update()
    {
        float timeLeft = totalTime - (Time.time - startTime);
        if (timeLeft < 0.0f)
        {
            timeLeft = 0.0f;
            //SceneManager.LoadScene("LoseScene", LoadSceneMode.Additive);
            //SceneManager.UnloadSceneAsync("")
=======
    void Update() {
         if (!levelComplete){
            float timeLeft = totalTime - (Time.time - startTime);
            if (timeLeft < 0.0f) {
                    timeLeft = 0.0f;
                    Time.timeScale = 0.0f; // Freeze the game
                    gameOverText.text = "Game Over"; // Show the "Game Over" message
            }
            else {
                string minutes = ((int)timeLeft / 60).ToString();
                string seconds = (timeLeft % 60).ToString("f2");
                timerText.text = minutes + ":" + seconds;
            }
>>>>>>> Stashed changes
        }
    }

        
    private void OnTriggerEnter2D(Collider2D other) // Use "Collider2D" instead of "Collider" for 2D games
    {
        if (other.CompareTag("LevelDoor")) // Replace "Player" with the tag of your player object
        {
             levelComplete = true;
        }
    }
}