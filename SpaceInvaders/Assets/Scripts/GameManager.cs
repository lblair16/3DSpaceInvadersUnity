using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //level info
    int level;
    //public List<Enemy> enemies;
    int enemies;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemies = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(enemies == 0 && level == 0)
        {
            level++;
            //spawn enemies
            SpawnEnemies(10);
            enemies = 10;
        }
        else if(enemies == 0)
        {
            level++;
            enemies = level * 20;
            SpawnEnemies(level * 20);
        }
    }

    void SpawnEnemies(int num)
    {
        for(int i = 0; i < num; i++)
        {
            Vector3 temp = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(50f, 100f));
            Instantiate(enemy, temp, Quaternion.identity);
        }
    }
}
