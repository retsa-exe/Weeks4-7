using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    //input the prefabs
    public GameObject paperPrefab;
    public GameObject scissorPrefab;
    public GameObject rockPrefab;

    //inputs from the panel
    public float speed;
    public float scale;

    //array list for spawned objects
    public List<GameObject> spawnedObjects;

    private void Start()
    {
        //new array list for the spawned objects
        spawnedObjects = new List<GameObject>();
    }

    private void Update()
    {
        //instantiate objects when space key down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //instantiate the object at mouse position
            GameObject newSpawned = Instantiate(paperPrefab, mousePos, Quaternion.identity);
            //add the new spawned object to list
            spawnedObjects.Add(newSpawned);
        }
    }
}
