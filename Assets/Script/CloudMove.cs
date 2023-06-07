using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    public float CloudMovespeed = 40;
    public double destroyCloud = -40.8;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cloudmoving();
        if (transform.position.x < destroyCloud)
        {
            Destroy(gameObject);
        }
    }

    public void cloudmoving()
    {
        transform.position += (Vector3.left * CloudMovespeed) * Time.deltaTime;
    }
}
