using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class clockScript : MonoBehaviour
{
    public AudioClip chime;
    public float speed = 5f;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, - speed * Time.deltaTime);

        t += speed * Time.deltaTime;

        if (t > 30)
        {
            t = 0;
        }
    }
}
