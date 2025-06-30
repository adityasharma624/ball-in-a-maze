using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public GameObject winPanel;
    public GameObject losePanel;
    public GameObject restartButton;

    public void GameOverScreen(bool hasWon)
    {
        if (hasWon) winPanel.SetActive(true);
        else losePanel.SetActive(true);

        restartButton.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
