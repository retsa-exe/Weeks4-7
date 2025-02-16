using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnerScript : MonoBehaviour
{
    //input the prefabs
    public GameObject paperPrefab;
    public GameObject scissorPrefab;
    public GameObject rockPrefab;

    //get the dropdown option
    public TMP_Dropdown dropdown;

    //array list for spawned objects
    public List<GameObject> papers;
    public List<GameObject> scissors;
    public List<GameObject> rocks;

    private void Start()
    {
        //new array list for the spawned objects
        papers = new List<GameObject>();
        scissors = new List<GameObject>();
        rocks = new List<GameObject>();
    }

    private void Update()
    {
        //remove the empty elements in the list
        papers.RemoveAll(GameObject => GameObject == null);
        scissors.RemoveAll(GameObject => GameObject == null);
        rocks.RemoveAll(GameObject => GameObject == null);

        //instantiate objects when space key down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //instantiate the object accoding to the dropdown
            if (dropdown.value == 0)
            {
                //instantiate paper
                GameObject newSpawned = Instantiate(paperPrefab, mousePos, Quaternion.identity);
                //add the new spawned object to list
                papers.Add(newSpawned);
            }
            else if (dropdown.value == 1)
            {
                //instantiate scissor
                GameObject newSpawned = Instantiate(scissorPrefab, mousePos, Quaternion.identity);
                //add the new spawned object to list
                scissors.Add(newSpawned);
            }
            else if (dropdown.value ==2)
            {
                //instantiate rock
                GameObject newSpawned = Instantiate(rockPrefab, mousePos, Quaternion.identity);
                //add the new spawned object to list
                rocks.Add(newSpawned);
            }
        }
    }
}
