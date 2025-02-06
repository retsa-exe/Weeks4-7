using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showWhenNear : MonoBehaviour
{
    public GameObject talkingBubble;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        talkingBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, target.position);

        if (distance > 1)
        {
            talkingBubble.SetActive(false);
        }
        else
        {
            talkingBubble.SetActive(true);
        }
    }
}
