using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float rotatespeed = 40.0f;
    public ParticleSystem DirtParticle;
    public ParticleSystem DirtParticle1;
    public ParticleSystem SmokeParticle;
    public float playerHealth = 10f;
    private bool forward = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move player
        if (Input.GetKey(KeyCode.W))
        {
            forward = true;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (forward == true);
            {
                DirtParticle.Play();
                DirtParticle1.Play();
            }
            
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            DirtParticle.Stop();
            DirtParticle1.Stop();
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotatespeed);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            SmokeParticle.Play();
        }

        if (Input.GetKey(KeyCode.F))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotatespeed);
        }

    }
}
