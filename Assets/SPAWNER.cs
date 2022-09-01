using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNER : MonoBehaviour
{
    public GameObject[] obstaclePatterns;
    private float timebtwspawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;


    private void Update()
    {
        if (timebtwspawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timebtwspawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }

}
