using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    //public int enemyHealth = 10;
    public float speed = 5f;
    
    private GameObject player;

    public ParticleSystem SmokeParticle;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position += transform.forward * speed * Time.deltaTime;


        //if (enemyHealth < 5);
        //{
        //  SmokeParticle.Play();
        //Debug.Log("Critical");
        //}

        //if (enemyHealth < 1);
        //{
        //  Debug.Log("Enemy Destroyed");
        //Destroy(gameObject);

        //}
    }

    

    //private void OnTriggerEnter(Collider collision)
    //{
      //  if (collision.gameObject.CompareTag("Potato"));
      //  {
        //    enemyHealth--;
          //  Debug.Log("Hit!");
        //}

        
    //}
}
