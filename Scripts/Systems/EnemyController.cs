using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GegnerEinheit[] enemyTypes;
    public GegnerEinheit currentGegner;
    public Sprite CurrentEnemySprite;

    public void SpawnEnemy()
    {
        int randomNum = Random.Range(0, enemyTypes.Length);
        currentGegner = enemyTypes[randomNum];
        ChangeSprite(currentGegner.MonsterBild.sprite);
    }

    public void ChangeSprite(Sprite newSprite)
    {
        CurrentEnemySprite = newSprite;
    }
}
