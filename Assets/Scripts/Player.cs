using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;

    [SerializeField] private float yTravel;
    [SerializeField] private float ySpeed;
    [SerializeField] private float yLimit;

    [SerializeField] private GameObject gameOver;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, ySpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < yLimit)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + yTravel);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -yLimit)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - yTravel);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameOver.SetActive(true);
        Destroy(gameObject);
    }
}
