using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantPotato : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projectilePrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //launch a projectile from player
            Instantiate(projectilePrefab, transform.position, transform.rotation);
        }
    }
}
