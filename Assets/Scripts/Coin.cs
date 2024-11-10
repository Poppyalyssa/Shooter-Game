using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 3f;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, lifetime);
     
    }

    
    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            FindObjectOfType<GameManager>().EarnScore(1);

            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
