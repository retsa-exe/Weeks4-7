using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPmanagement : MonoBehaviour
{
    public int HP;
    public PlayerMove player;
    private void Start()
    {
        HP = 10;
    }

    private void Update()
    {
        if (HP <= 0)
        {
            player.isDead = true;
        }
    }

    void takeDamage(int damage)
    {
        HP -= damage;
    }
}
