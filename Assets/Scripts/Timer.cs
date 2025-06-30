using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public CollectableManager collectableManager;
    public float timeValue = 60.0f;
    private bool isTimerRunning = false;
    private float currentTime;

    public Text timerText;

    private void Start()
    {
        isTimerRunning = true;
        currentTime = timeValue;
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0.0f && !collectableManager.allCoinsCollected)
            {
                currentTime = 0.0f;
                isTimerRunning=false;
                GameManager.instance.GameOverScreen(false);
            }

            if (collectableManager.allCoinsCollected)
            {
                isTimerRunning = false;
                GameManager.instance.GameOverScreen(true);
            }
            
            updateTimerText();
        }
    }

    void updateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60.0f);
        int seconds = Mathf.FloorToInt(currentTime % 60.0f);

        timerText.text = string.Format("Time Left: {0:00}:{1:00}", minutes, seconds);
    }
}
