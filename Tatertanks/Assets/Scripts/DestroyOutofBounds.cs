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
    public float delay = 2.0f;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, delay);
        
    }
}
