using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject Cloud;
    public int rate = 2;
    public float timer = 0;
    public float batas = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCloud();
            timer = 0;
        }
    }


    void spawnCloud()
    {
        float batasAtas = transform.position.y + batas;
        float batasBawah = transform.position.y - batas;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(batasBawah, batasAtas), 0), transform.rotation);
    }
}
