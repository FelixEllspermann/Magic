using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Zauber 
{
    public  int ID;
    public void Use()
    {
        Debug.Log("Zauber Benutzt");
    }
}
