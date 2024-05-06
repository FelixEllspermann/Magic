using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Zauber Karte", menuName = "Karten/Zauber Karte", order = 1)]
public class ZauberKarte : ScriptableObject
{
    public int ID;
    public Image KartenBild;
    public string KartenName;
    public string KartenBeschreibung;

}
