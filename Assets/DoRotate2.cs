using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoRotate2 : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    double accumulatedTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        accumulatedTime += Time.deltaTime;

        if (accumulatedTime > 15.0)
            this.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
       
    }
}
