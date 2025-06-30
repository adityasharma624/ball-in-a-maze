using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform initialPos;

    public CameraFollow cameraFollow;
    private void Start()
    {
        GameObject go = Instantiate(ballPrefab, initialPos.position, Quaternion.identity);
        cameraFollow.target = go.transform;
    }


}
