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
    
    //the variable controls the object limits
    public float objectlimits = 20;

    private void Update()
    {
        //instantiate objects when space key down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //instantiate the object accoding to the dropdown
            if (dropdown.value == 0)
            {
                Instantiate(paperPrefab, mousePos, Quaternion.identity);
            }
            else if (dropdown.value == 1)
            {
                Instantiate(scissorPrefab, mousePos, Quaternion.identity);
            }
            else if (dropdown.value ==2)
            {
                Instantiate(rockPrefab, mousePos, Quaternion.identity);
            }
        }
    }
}
