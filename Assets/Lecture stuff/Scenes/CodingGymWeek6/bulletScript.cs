using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
	public bool isFire = false;
	public float speed = 5;

    private void Update()
    {
		if (isFire)
		{
			transform.position += Vector3.up* speed * Time.deltaTime;
		}
		else
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 direction = mousePos - (Vector2)transform.position;
			transform.up = direction;
		}
	}

	public void Fire()
	{
		isFire = true;
		transform.parent = null;
		Destroy(gameObject, 5);
	}
}
