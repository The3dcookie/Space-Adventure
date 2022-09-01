using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiBullet : MonoBehaviour
{
    public GameObject MultipleBullet;
    public float timeBetweenShots = 0.1f;
    public bool canMultiply = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (canMultiply == true)
        {
            
            Instantiate(MultipleBullet, new Vector2(0.45f, 0.45f), Quaternion.Euler(0,0,1f));
           
            StartCoroutine(recoiltimer());
        }
            
    }
    IEnumerator recoiltimer()
    {
        canMultiply = false;
        yield return new WaitForSeconds(timeBetweenShots);
        canMultiply = true;

    }
}
