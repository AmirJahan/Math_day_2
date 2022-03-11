

using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerScript : MonoBehaviour
{
    [SerializeField] GameObject enemySample;

    public static List<GameObject> allEnemies =
        new List<GameObject>();

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {

            Vector3 randomPos =
                new Vector3(Random.Range(-50, 50),
                enemySample.transform.position.y,
                      Random.Range(-50, 50));

            GameObject newEnemy =
                Instantiate(enemySample,
                      randomPos,
                       Quaternion.identity);

            allEnemies.Add(newEnemy);
        }
    }
}
