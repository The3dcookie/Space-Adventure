using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBSTACLE : MonoBehaviour
{
    public int damage = 1;
    public float speed = 3;
    public GameObject effect;

    private void Update()
    {

        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("ROCKET"))
        {
            //player takes damage
            Instantiate(effect, transform.position, Quaternion.identity);
            collider.GetComponent<ROCKET>().health -= damage;
            Debug.Log(collider.GetComponent<ROCKET>().health);
            Destroy(gameObject);
        }
        //ScoreManager

        if (collider.CompareTag("Bullet"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }

       
    }
}