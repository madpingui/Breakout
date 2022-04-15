using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour
{
    public int rows;
    public int columns;
    public float spacing;
    public GameObject brickPrefab;

    private List<GameObject> bricks = new List<GameObject>();
    private List<Color> colors      = new List<Color>() 
    {
        new Color(255F/255f, 182F/255f, 193F/255f),
        new Color(250F/255f, 128F/255f, 114F/255f),
        new Color(255F/255f, 123F/255f, 0F/255f),
        Color.yellow,
        Color.green,
        Color.blue,
        new Color(104F/255f, 77F/255f, 119F/255f),
        Color.cyan,
    };

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
            var colorIndex = 0;
            for (int j = 0; j < rows; j++)
            {
                Vector2 spawnPos = (Vector2)transform.position + new Vector2(i * (brickPrefab.transform.localScale.x + spacing), -j * (brickPrefab.transform.localScale.y + spacing));
                GameObject brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);
                brick.GetComponent<SpriteRenderer>().material.color = colors[colorIndex];
                colorIndex++;
                if (colorIndex == colors.Count)
                    colorIndex = 0;
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
