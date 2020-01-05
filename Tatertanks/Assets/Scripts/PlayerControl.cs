using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10.0f;
    public float rotatespeed = 50.0f;
    public ParticleSystem DirtParticle;
    public ParticleSystem DirtParticle1;
    public ParticleSystem SmokeParticle;
    public float playerHealth = 10f;
    private bool forward = false;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    public AudioClip shootSound;
    public AudioClip jumpSound;
    //public AudioClip driveSound;
    private AudioSource playerAudio;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //move player
        if (Input.GetKey(KeyCode.W))
        {
            //playerAudio.PlayScheduled(driveSound, 1.0f);
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SmokeParticle.Play();
            playerAudio.PlayOneShot(shootSound, 1.0f);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(-Vector3.forward * Time.deltaTime * rotatespeed);
        }

        if (Input.GetKey(KeyCode.LeftShift) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * 20000, ForceMode.Impulse);
            Debug.Log("LAUNCH!");
            isOnGround = false;
            playerAudio.PlayOneShot(jumpSound, 1f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
