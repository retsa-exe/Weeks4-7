using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class dropdownScript : MonoBehaviour
{
    //drag in the dropdown UI, the image component of preview
    public TMP_Dropdown dropdown;
    public Image preview;

    private void Start()
    {
        //initiate preview image when start
        preview.sprite = dropdown.options[0].image;
    }

    //add index to onValueChanged function
    public void OnValueChanged (int index)
    {
        //change the sprite accroding to the dropdown option
        preview.sprite = dropdown.options[index].image;
    }
}
