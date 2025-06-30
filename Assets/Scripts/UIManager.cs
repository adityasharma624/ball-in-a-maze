using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void ChangeCurrentScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        int nextIndex = currentScene.buildIndex + 1;

        SceneManager.LoadScene(nextIndex);
    }
}
