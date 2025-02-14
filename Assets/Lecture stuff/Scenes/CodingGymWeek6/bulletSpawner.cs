using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> spawnedBullets;
    public bulletScript currentBullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentBullet == null)
        {
            GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
            newBullet.transform.parent = transform;

            spawnedBullets.Add(newBullet);

            currentBullet = newBullet.GetComponent<bulletScript>();
        }

        if (Input.GetMouseButtonDown(0) && currentBullet != null)
        {
            currentBullet.Fire();
            currentBullet = null;
        }
    }
}
