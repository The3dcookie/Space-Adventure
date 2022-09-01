using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBulletSpawner : MonoBehaviour
{
    public GameObject Bullet;
    Vector2 direction;
    public bool canMultiply = true;
    // Start is called before the first frame update
    void Start()
    {
        direction = (transform.localRotation * Vector2.right).normalized;

        if (canMultiply == true)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

