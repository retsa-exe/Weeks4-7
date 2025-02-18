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

    //call sliders
    public Slider scaleSlider;
    public Slider speedSlider;

    //new spawned object
    GameObject newObject;

    //counter variables
    public int paperCount;
    public int scissorCount;
    public int rockCount;

    //call the counter texts
    public TextMeshProUGUI paperText;
    public TextMeshProUGUI scissorText;
    public TextMeshProUGUI rockText;


    private void Start()
    {
        //initialize the counter
        paperCount = 0;
        scissorCount = 0;
        rockCount = 0;

        //assign the value to the text
        paperText.text = paperCount.ToString();
        scissorText.text = scissorCount.ToString();
        rockText.text = rockCount.ToString();
    }

    private void Update()
    {
        //instantiate objects when space key down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //get mouse position
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //instantiate the object accoding to the dropdown, and update counter
            if (dropdown.value == 0)
            {
                newObject = Instantiate(paperPrefab, mousePos, Quaternion.identity);
                paperCount++;
                paperText.text = paperCount.ToString();
            }
            else if (dropdown.value == 1)
            {
                newObject = Instantiate(scissorPrefab, mousePos, Quaternion.identity);
                scissorCount++;
                scissorText.text = scissorCount.ToString();
            }
            else if (dropdown.value ==2)
            {
                newObject = Instantiate(rockPrefab, mousePos, Quaternion.identity);
                rockCount++;
                rockText.text = rockCount.ToString();
            }

            //change the object scale with the slider value
            float scale = scaleSlider.value;
            newObject.transform.localScale = Vector3.one * scale;

            //change the speed with the slider value
            movement movement = newObject.GetComponent<movement>();
            movement.speed = speedSlider.value;
        }
    }
}
