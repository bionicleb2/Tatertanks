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
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Potato"));
        {
            enemyHealth -= 1;

        }

        if (enemyHealth < 5) ;
        {
            SmokeParticle.Play();
        }

        if (enemyHealth < 1);
        {
            Destroy(gameObject);
        }
    }
}
