using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollision : MonoBehaviour
{
    private Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Base" || other.tag == "Player") {
            GameOver.isPlayerDead = true;
        }
    }
}
