using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeWhenClicked : MonoBehaviour
{
    //call the sprite renderer for contain checks
    public SpriteRenderer sr;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                //destroy object when clicked
                Destroy(gameObject);
            }
        }
    }
}
