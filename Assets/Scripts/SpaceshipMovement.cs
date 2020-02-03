using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    public Transform bulletSpawnPos;
    public GameObject bullet;

    public Transform moveUp;
    public Transform moveDown;
    public Transform moveLeft;
    public Transform moveRight;

    public float speed;

    public float verticalDistance;
    public float horizontalDistance;

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, moveLeft.position, speed);
            if (transform.position.x < -horizontalDistance)
            {
                transform.position = new Vector2(-horizontalDistance, transform.position.y);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, moveRight.position, speed);
            if (transform.position.x > horizontalDistance)
            {
                transform.position = new Vector2(horizontalDistance, transform.position.y);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, moveUp.position, speed);
            if (transform.position.y > verticalDistance)
            {
                transform.position = new Vector2(transform.position.x, verticalDistance);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, moveDown.position, speed);
            if (transform.position.y < -verticalDistance)
            {
                transform.position = new Vector2(transform.position.x, -verticalDistance);
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instance =  Instantiate(bullet);
            instance.transform.position = bulletSpawnPos.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet") || collision.CompareTag("Enemy"))
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(0);
    }
}
