using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int enemyHealth = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        enemyHealth -= 1;
        if (enemyHealth < 1)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
    }
}
