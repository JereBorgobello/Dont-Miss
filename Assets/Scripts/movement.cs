using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public gameManage manager;

    public float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0) * moveSpeed * Time.deltaTime;

        if (horizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);

        }
        else if(horizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "zombi" || collision.gameObject.tag == "volador")
        {
            manager.GameOver();
            Destroy(gameObject);
        }
    }
}
