using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static int Score = 0;
    public Text scoreText;

    public List<GameObject> enemies;
    public int level = 0;

    public List<Transform> positions;

    public float minTime;
    public float maxTime;

    public float levelInterval;

    bool isReady = true;

    float randMovementTimer = 0f;
    float timeLimit;

    float levelTimer;

    private void Start()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
        Physics2D.IgnoreLayerCollision(9, 9);
    }

    private void Update()
    {
        if(isReady)
        {
            timeLimit = Random.Range(minTime, maxTime);
        }

        randMovementTimer += Time.deltaTime;

        if(randMovementTimer >= timeLimit)
        {
            randMovementTimer -= timeLimit;

            int rand = Random.Range(0, level);

            GameObject instance = Instantiate(enemies[rand]);

            rand = Random.Range(0, positions.Count);

            instance.transform.position = positions[rand].position;
        }

        levelTimer += Time.deltaTime;

        if(levelTimer >= levelInterval)
        {
            levelTimer -= levelInterval;

            if(level != enemies.Count)
            {
                level++;
            }
        }
    }
}
