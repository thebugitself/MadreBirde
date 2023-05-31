using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public double spawnRate = 2;
    private float timer = 0;
    public float batas = 10;
    public Logic logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.playerScore >= 10)
        {
            spawnRate = 1.5;
        }
        if (logic.playerScore >= 20)
        {
            spawnRate = 1;
        }
        if (logic.playerScore >= 30)
        {
            spawnRate = 0.5;
        }
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float batasAtas = transform.position.y + batas;
        float batasBawah = transform.position.y - batas;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(batasBawah, batasAtas), 0), transform.rotation);
    }

}
