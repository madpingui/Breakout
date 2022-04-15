﻿using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        FindObjectOfType<BrickManager>().RemoveBrick(this);
    }
}
