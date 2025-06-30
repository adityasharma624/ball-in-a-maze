using UnityEngine;

public class Collectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("DestroyCollectables", 0.05f);
        }
    }

    void DestroyCollectables()
    {
        Destroy(this.gameObject);
    }
}
