using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        Respawn();
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        GetComponent<Rigidbody2D>().velocity = Random.insideUnitSphere.normalized * speed;
    }
}
