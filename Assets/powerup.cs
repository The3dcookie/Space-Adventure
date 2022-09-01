using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{
    public float speed = 10;
    public GameObject effect;
    public GameObject rapidFire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ROCKET"))
        {
            Instantiate(rapidFire, transform.position, Quaternion.identity);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}