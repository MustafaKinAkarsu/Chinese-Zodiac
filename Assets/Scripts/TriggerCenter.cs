using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCenter : MonoBehaviour
{
    public GameObject oxbod;
    private Quaternion initialRotation_;
    // Start is called before the first frame update
    public void Start()
    {
        initialRotation_ = oxbod.transform.localRotation;
    }
    public void MoveToCenter()
    {
        oxbod.transform.localPosition = new Vector3(0.284f, 0.6807f, 0.345f);
        oxbod.transform.localRotation = initialRotation_;
        
    }
}
