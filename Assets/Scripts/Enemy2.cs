using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy1
{
    public GameObject bullet;
    public float interval;

    float timer;

    private void Update()
    {
        Movement();
        BulletSpawn();
    }

    protected void BulletSpawn()
    {
        timer += Time.deltaTime;
        if (timer > interval)
        {
            timer -= interval;
            GameObject instance = Instantiate(bullet);
            instance.transform.position = moveDirection.position;
            instance.transform.GetChild(0).GetComponent<Transform>().localPosition = new Vector2(0f, -1f);
            instance.layer = 9;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckForCollision(ref collision);
    }
}
