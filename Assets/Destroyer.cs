using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject effect;
    private void OnTriggerEnter2D(Collider2D destroyer)
    {
        if (destroyer.CompareTag("Obstacle"))
        {
            Destroy(destroyer.gameObject);
        }
        if (destroyer.CompareTag("Bullet"))
        {
            Destroy(destroyer.gameObject);
        }
    }


}
