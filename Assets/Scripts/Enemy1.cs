using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public Transform moveDirection;

    public float speed;

    private void Update()
    {
        Movement();
    }

    protected void Movement()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveDirection.position, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CheckForCollision(ref collision);
    }

    protected void CheckForCollision(ref Collider2D col)
    {
        if (col.CompareTag("EnemyDestroy") || col.CompareTag("Bullet"))
        {
            Destroy(gameObject);

            if (col.CompareTag("Bullet"))
            {
                Destroy(col.gameObject);

                EnemySpawner.Score += 5;
                Camera.main.GetComponent<EnemySpawner>().scoreText.text = "SCORE : " + EnemySpawner.Score;
            }
        }
    }
}
