using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CanvasReader : MonoBehaviour
{
    public Transform centerTransform;
    public TextMeshProUGUI infoText;
    public Transform currentPos;
    // Update is called once per frame
    void Update()
    {
        infoText.text = "Needed coordinates = x 0,4743 0,80 , z 0,3571 0,5913" + "\n CenterPos = " + centerTransform.localPosition + "\n CurrentPos = " + currentPos.localPosition; 
    }
}
