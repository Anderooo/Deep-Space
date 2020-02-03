using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform moveDirection;

    public float speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, moveDirection.position, speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("BulletDestroy") || collision.CompareTag("EnemyDestroy"))
        {
            Destroy(gameObject);
        }
    }
}
