using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundController : MonoBehaviour
{
    public int currentRound;
    public bool isPlayerTurn = true; 
    public void AdvanceRound()
    {
        currentRound++;
    }

}
