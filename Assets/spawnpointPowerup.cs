using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnpointPowerup : MonoBehaviour
{
    public GameObject Powerup;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Powerup, transform.position, Quaternion.identity);
    }

    private void Update()
    {
       
    }

}
