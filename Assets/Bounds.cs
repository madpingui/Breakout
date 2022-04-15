using UnityEngine;

public class Bounds : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Ball>().Respawn();
        FindObjectOfType<BrickManager>().ResetLevel();
    }
}
