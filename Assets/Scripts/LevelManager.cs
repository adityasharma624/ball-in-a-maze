using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform initialPos;

    private void Start()
    {
        Instantiate(ballPrefab, initialPos.position, Quaternion.identity);
    }


}
