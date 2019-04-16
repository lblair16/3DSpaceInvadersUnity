using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameManager GM;
    Vector3 temp;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GM").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.position;
        temp.z += speed * Time.deltaTime;
        transform.position = temp;
        if(temp.z > 100)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GM.enemies--;
            GM.GUIEnemies.text = "Enemies: " + GM.enemies;
            GM.score += 10;
            GM.GUIScore.text = "Score: " + GM.score;
        }
    }
}
