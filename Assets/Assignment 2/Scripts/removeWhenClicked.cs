using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeWhenClicked : MonoBehaviour
{
    //call the sprite renderer for contain checks
    public SpriteRenderer sr;

    //boolean to check if is time to play the animation
    public bool isDead;
    float t; //timer variable

    //animation curve for scale and transparency
    public AnimationCurve scaleCurve;
    public AnimationCurve colorCurve;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                //destroy object when clicked
                isDead = true;
                Destroy(gameObject, 1); //the animation lasts for 1 sec
            }
        }

        if (isDead)
        {
            t += Time.deltaTime / 30;
            //scale the object 
            transform.localScale = transform.localScale * scaleCurve.Evaluate(t);

            //change the transparncy
            Color currentColor = sr.color;
            currentColor.a = colorCurve.Evaluate(t * 20);
            sr.color = currentColor;
        }
    }
}
