using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class previewScipt : MonoBehaviour
{
    //call slider
    public Slider slider;
    //the preview image need to be changed
    public Image preview;

    private void Update()
    {
        //get rect Transform component
        RectTransform rt = preview.GetComponent<RectTransform>();
        //change the size with the slider
        rt.localScale = Vector3.one * slider.value * 2;
    }
}
