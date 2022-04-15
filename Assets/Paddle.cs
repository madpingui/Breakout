using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed = 5f;

    private float input;

    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }
}
