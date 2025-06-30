using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime;

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Collided with Wall");
            ScoreManager.instance.AddScore(-1);
        }
    }
}
