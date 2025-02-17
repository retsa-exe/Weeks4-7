using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement : MonoBehaviour
{
    //object info
    Vector2 direction;
    public float speed;

    private void Start()
    {
        direction = Random.insideUnitCircle;
    }

    private void Update()
    {
        //record current position
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        //add the direction acroding to the speed and direction
        pos += direction * speed * Time.deltaTime;

        //make the object bounce in the screen
        if (pos.x < -screenPos.x)
        {
            //reset the value
            pos.x = -screenPos.x;
            //reverse the direction
            direction.x *= -1;
        }
        if (pos.x > screenPos.x)
        {
            pos.x = screenPos.x;
            direction.x *= -1;
        }
        if (pos.y > screenPos.y)
        {
            pos.y = screenPos.y;
            direction.y *= -1;
        }
        if (pos.y < -screenPos.y)
        {
            pos.y = -screenPos.y;
            direction.y *= -1;
        }

        //update object position
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }
}
