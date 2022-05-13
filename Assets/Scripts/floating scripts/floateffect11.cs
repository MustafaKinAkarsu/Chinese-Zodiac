using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floateffect11 : MonoBehaviour
{
    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(2.174f, 2.18f, 1.144f);
        pointB = new Vector3(2.204f, 2.18f, 1.144f);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}