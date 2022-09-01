using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    public GameObject effect;
    public float direction;
    private void Update()
    {
        transform.Translate(new Vector2(1,0) * speed * Time.deltaTime);

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Obstacle")) {
    //        Instantiate(effect, transform.position, Quaternion.identity);
    //        Destroy(collision.gameObject);
    //        DestroyImmediate(this.gameObject);
    //    }
            
    //    Debug.Log("abracadabra");
    //    Debug.Log(collision.gameObject.name);
    //}
}