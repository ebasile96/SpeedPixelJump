using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube, pyramid, bonus, doppiapiramide, vuoto;
    private float spawnRate;
    float nextSpawn = 0f;
    int whatToSpawn;
    public Player p1;

    void Update()
    {
        if(Time.time > nextSpawn && p1.isDead == false)
        {
            whatToSpawn = Random.Range(1, 7);

            spawnRate = Random.Range(0.5f, 1.5f);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(cube, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(pyramid, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(bonus, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(vuoto, transform.position, Quaternion.identity);
                    break;
                
                case 5:
                    Instantiate(doppiapiramide, transform.position, Quaternion.identity);
                    break;


            }

            nextSpawn = Time.time + spawnRate;
        }
    }
}
