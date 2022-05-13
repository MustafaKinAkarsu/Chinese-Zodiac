using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floateffect1 : MonoBehaviour
{
    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(-2.15f, 2.18f, .744f);
        pointB = new Vector3(-2.17f, 2.18f, .744f);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
