using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float xPos;
    [SerializeField] private int enemyCount;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 20)
            {
                //randomize the x-position
                xPos = Random.Range(-5, 5);
                //create a new enemy
                Instantiate(enemy, new Vector3(xPos, 1.263637f, 18), Quaternion.identity);
                //wait for 1 second before running again
                yield return new WaitForSeconds(1);
                //add 1 to enemyCount
                enemyCount += 1;
            }


    }
}
