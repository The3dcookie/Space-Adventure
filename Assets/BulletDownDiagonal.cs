using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDownDiagonal : MonoBehaviour
{
    public float speed = 10;
    public GameObject effect;
    private void Update()
    {
        transform.Translate(new Vector2(1f, -0.45f) * speed * Time.deltaTime);

    }
}
