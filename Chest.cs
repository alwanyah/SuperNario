using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            ScoreText.coinAmount += 10;
            Destroy(gameObject);
        }
    }
}
