using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5;
    public bool isDead = true;
    public Transform startPoint;

    private void Start()
    {
        transform.position = startPoint.position;
    }

    private void Update()
    {
        if (!isDead)
        {
            Vector2 pos = transform.position;
            pos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            pos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;

            transform.position = pos;
        }
    }
}
