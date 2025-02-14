using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankScript : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        pos.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.position = pos;
    }
}
