using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volador : MonoBehaviour
{
    public Transform playerPos;
    public gameManage manager;
    public GameObject player;
    private Vector2 currentPos;

    public float speed;

    private void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

        if (playerPos.transform.position.x < gameObject.transform.position.x)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        else if (playerPos.transform.position.x > gameObject.transform.position.x)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
        manager.AddPunto();
    }
}
