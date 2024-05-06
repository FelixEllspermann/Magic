using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skelett : Enemy
{
    new public int ID = 0;
    new public int health = 5;
    int currentHealth;
    new public int damage = 1;

    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");
        currentHealth = health;
    }

    new public void takeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            die();
        }
    }

    new public void die()
    {
        //Sterbe Logik
        Debug.Log("Monster died");
    }

}
