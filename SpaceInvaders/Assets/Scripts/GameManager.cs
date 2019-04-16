using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //level info
    int level;
    public int enemies;
    public int score;
    public GameObject enemy;
    public Text GUIScore;
    public Text GUILevel;
    public Text GUIEnemies;

    // Start is called before the first frame update
    void Start()
    {
        enemies = 0;
        score = 0;
        GUIScore.text = "Score: " + score;
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
            GUIEnemies.text = "Enemies: " + enemies;
            GUILevel.text = "Level: " + level;
        }
        else if(enemies == 0)
        {
            level++;
            enemies = 10 + (level * 3);
            SpawnEnemies(10 + (level * 3));
            GUIEnemies.text = "Enemies: " + enemies;
            GUILevel.text = "Level: " + level;
        }
    }

    void SpawnEnemies(int num)
    {
        for(int i = 0; i < num; i++)
        {
            Vector3 temp = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), Random.Range(50f, 100f));
            Instantiate(enemy, temp, Quaternion.identity);
        }
    }
}
