using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float kelipatanLompat;
    public Logic logic;
    public bool birdStillAlive = true;
    public GameObject buntut1;
    public GameObject buntut2;
    public GameObject kacamata;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
    }

    // Update is called once per frame  
    void Update()
    {
        if (Input.touchCount > 0 && birdStillAlive)
        {
            myRigidbody.velocity = Vector2.up * kelipatanLompat;
        }

        if(birdStillAlive == false)
        {
            myRigidbody.transform.Rotate(new Vector3(0, 50, 50)) ;
            logic.highScoreShow();
        }
        if (birdStillAlive)
        {
            buntut1.transform.Rotate(new Vector3(0, 3, 0)); 
            buntut2.transform.Rotate(new Vector3(0, -3, 0));
        }
        if(logic.playerScore >= 10)
        {
            kacamata.SetActive(true);
}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "MainCamera" || collision.gameObject.tag == "pipe")
        {
            logic.gameOver();
            birdStillAlive = false;
        }
    }
}
