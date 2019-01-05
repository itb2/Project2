using UnityEngine;
using System.Collections;

public class DoRotate : MonoBehaviour
{

    public float rotationSpeed = 300.0f;

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        AudioSource audio = GetComponent<AudioSource>();
       
        if (Input.GetKey("r"))
        {
            this.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown("r"))
        {
            audio.Play();
        }
        if(Input.GetKeyUp("r")){
            audio.Stop();
        }
    }
}