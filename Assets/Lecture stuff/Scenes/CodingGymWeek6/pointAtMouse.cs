using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointAtMouse : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;
        transform.up = direction;
    }
}
