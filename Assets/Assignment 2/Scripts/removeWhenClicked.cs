using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeWhenClicked : MonoBehaviour
{
    //call spawner for the lists
    public SpawnerScript spawner;
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
                //remove from the list
                if (spawner.papers.Contains(gameObject))
                {
                    spawner.papers.Remove(gameObject);
                    spawner.papers.RemoveAll(GameObject => GameObject == null);
                }
                if (spawner.scissors.Contains(gameObject))
                {
                    spawner.scissors.Remove(gameObject);
                    spawner.scissors.RemoveAll(GameObject => GameObject == null);
                }
                if (spawner.rocks.Contains(gameObject))
                {
                    spawner.rocks.Remove(gameObject);
                    spawner.rocks.RemoveAll(GameObject => GameObject == null);
                }
                //destroy object when clicked
                Destroy(gameObject);
            }
        }
    }
}
