using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float movespeed;

    private int currentPoint;
    

    // Use this for initialization
    void Start()
    {
        transform.position = patrolPoints[2].position;
        currentPoint = 0;
      

    }

    // Update is called once per frame
    void Update()
    {
        

        if (transform.position == patrolPoints[currentPoint].position)
        {
            currentPoint++;

        }

        if (currentPoint >= patrolPoints.Length)
        {
            currentPoint = 0;

        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, movespeed * Time.deltaTime);
    }
}
