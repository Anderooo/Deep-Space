using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy2
{
    public float minSwitchTime;
    public float maxSwitchTime;

    float randMOvementTimer;
    float timeLimit = 0;

    private void Start()
    {
        //speed = speed * 1.5f;
    }

    private void Update()
    {
        Movement();
        BulletSpawn();
        RandomMovement();
    }

    protected void RandomMovement()
    {
        randMOvementTimer += Time.deltaTime;
        if(randMOvementTimer >= timeLimit)
        {
            randMOvementTimer -= timeLimit;
            timeLimit = Random.Range(minSwitchTime, maxSwitchTime);

            int dir = Random.Range(-1, 2);

            transform.GetChild(0).transform.localPosition = new Vector2((float)(dir), -1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckForCollision(ref collision);
    }
}
