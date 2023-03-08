using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclespawner : MonoBehaviour
{
    public GameObject[] obstacles;

    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    
    public IEnumerator SpawnObstacle()
    {
        while(true)
        {
            int randomIndex = Random.Range(0, obstacles.Length);
            float minTime = 0.6f;
            float maxTime = 1.8f;
            float randomTime = Random.Range(minTime, maxTime);

            Instantiate(obstacles[randomIndex], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
                                                                           