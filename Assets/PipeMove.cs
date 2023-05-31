using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 10;
    public double destroyX = -40.8;
    public Logic logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        pipaGerak();
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
        if(logic.playerScore >= 5)
        {
            moveSpeed = 12;
        }
        if (logic.playerScore >= 10)
        {
            moveSpeed = 14;
        }
        if (logic.playerScore >= 15)
        {
            moveSpeed = 16;
        }
        if (logic.playerScore >= 20)
        {
            moveSpeed = 18;
        }

    }

    public void pipaGerak()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
