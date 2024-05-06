using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Feuerball : Zauber
{
    public Enemy enemy;
    public int damage;
    new public int ID = 0;


    new public void Use()
    {
        enemy.takeDamage(damage);
    }
}
