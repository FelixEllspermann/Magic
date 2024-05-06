using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Gegner", menuName = "Gegner", order = 1)]
public class GegnerEinheit : ScriptableObject
{
    public int ID;
    public Image MonsterBild;
    public string MonsterName;
    public string MonsterBeschreibung;
}
