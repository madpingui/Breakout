using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public int rows;
    public int columns;
    public float spacing;
    public GameObject brickPrefab;

    private List<GameObject> bricks = new List<GameObject>();

    void Start()
    {
        ResetLevel();
    }

    public void ResetLevel()
    {
        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab.transform.localScale.x + spacing), -j * (brickPrefab.transform.localScale.y + spacing));
                GameObject brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);
                bricks.Add(brick);
            }
        }
    }

    public void RemoveBrick(Brick brick)
    {
        bricks.Remove(brick.gameObject);
        if(bricks.Count == 0)
        {
            ResetLevel();
        }
    }
}
