using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topBound = 400;
    private float rightBound = 400;
    private float bottomBound = 0;
    private float leftBound = 0;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < bottomBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < topBound)
        {
            Destroy(gameObject);
        }
    }
}
