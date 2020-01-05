using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPotato : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    public ParticleSystem SmokeParticle;
    public AudioClip shootSound;
    private AudioSource enemyAudio;

    void Start()
    {
        InvokeRepeating("SpawnPotato", 5, 2);
        enemyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPotato()
    {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
        SmokeParticle.Play();
        enemyAudio.PlayOneShot(shootSound, 1f);
}


}