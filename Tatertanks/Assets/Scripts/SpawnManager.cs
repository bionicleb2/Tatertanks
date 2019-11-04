using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float spawnStart = 10;
    public float spawnEnd = 390;
    public float spawnY = 30;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnStart, spawnEnd), 30, Random.Range(spawnStart, spawnEnd));

        Instantiate(enemy, spawnPos, enemy.transform.rotation);
    }

}
