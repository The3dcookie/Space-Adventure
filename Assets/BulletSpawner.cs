using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject Bullet;
    public float CooldownTimer = 1.5f;
    public bool canShoot = true;
    Vector2 direction;


    private void Start()
    {
        direction = (transform.localRotation * Vector2.right).normalized;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && canShoot == true)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            StartCoroutine(Cooldown()); 
            
        }
       
        


    }

    private void start()
    {
        
    }
    IEnumerator Cooldown()
    {
        canShoot = false;
        yield return new WaitForSeconds(CooldownTimer);
        canShoot = true;
        
    }

}
