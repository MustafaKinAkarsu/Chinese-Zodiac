using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floateffect7 : MonoBehaviour
{
    public float speed = 1.19f;
    Vector3 pointA;
    Vector3 pointB;

    void Start()
    {
        pointA = new Vector3(.424f, 2.18f, 2.444f);
        pointB = new Vector3(.464f, 2.18f, 2.444f);
    }

    void Update()
    {
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
