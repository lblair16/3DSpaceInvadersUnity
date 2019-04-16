using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Vector3 temp;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        temp = transform.position;
        temp.z -= speed * Time.deltaTime;
        transform.position = temp;
        //lose condition
        if(temp.z < -11)
        {
            SceneManager.LoadScene("Main");
        }
    }
}
