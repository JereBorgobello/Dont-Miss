using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float zombiTimer;
    public float timerDefault;
    public float voladorTimer;

    public GameObject zombi;
    public GameObject volador;

    void Update()
    {
        zombiTimer  -= Time.deltaTime;
        voladorTimer -= Time.deltaTime;

        if(zombiTimer <= 0)
        {
            SpawnZombi();
            zombiTimer = timerDefault;
        }

        if(voladorTimer <= 0)
        {
            SpawnVolador();
            voladorTimer = timerDefault +2;
        }
    }

    void SpawnZombi()
    {
        Instantiate(zombi, transform.position, transform.rotation);
    }

    void SpawnVolador()
    {
        Instantiate(volador, transform.position, transform.rotation);
    }
}
