using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject[] PowerSpawnPoint;
    public float timeBetweenPower = 5f;
    public bool canSpawn = true;
    public float startPower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (canSpawn == true)
        {
            int rand = Random.Range(0, PowerSpawnPoint.Length);
            Instantiate(PowerSpawnPoint[rand], PowerSpawnPoint[rand].transform.position, Quaternion.identity);
            StartCoroutine(Cooldown());
            Debug.Log("powerrandom = " + rand);

        }
    }

    IEnumerator Cooldown()
    {
        canSpawn = false;
        yield return new WaitForSeconds(timeBetweenPower);
        canSpawn = true;

    }
}
