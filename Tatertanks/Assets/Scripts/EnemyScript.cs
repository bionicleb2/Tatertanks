using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemyHealth = 10;
   
    public ParticleSystem SmokeParticle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth < 5);
        {
            SmokeParticle.Play();
            Debug.Log("Critical");
        }

        if (enemyHealth <= 0);
        {
            Debug.Log("Enemy Destroyed");
            Destroy(gameObject);
            
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Potato"));
        {
            enemyHealth -= 1;
            Debug.Log("Hit!");
        }

        
    }
}
