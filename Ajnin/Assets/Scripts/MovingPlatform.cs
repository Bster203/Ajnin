using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;                 //Speed of the platform
    public int startingPoint;           //Starting index (position of the platform)
    public Transform[] points;          //An array of tansform points (positions where the platform needs to move)

    private int i;  //index of the array

    void Start()
    {
        transform.position = points[startingPoint].position;    //Setting the position of the platform to 
                                                                //the position of one of the points using index "startingPoint"
    }

    void Update()
    {

    }
}
