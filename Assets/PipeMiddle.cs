using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public Logic logic;
    public BirdScript bird;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
        bird = GameObject.FindGameObjectWithTag("birdo").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bird.birdStillAlive)
        {
            if (collision.gameObject.layer == 3)
            {
                logic.addScore(1);
            }
        }
    }
}
