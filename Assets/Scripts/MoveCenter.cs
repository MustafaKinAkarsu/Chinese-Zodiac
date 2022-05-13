using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oculus.Interaction
{
    public class MoveCenter : MonoBehaviour
    {
        public static MoveCenter instance;
        private Quaternion initialRotation_;
        public Vector3 desiredPosition;
        public static bool Check;
        // Start is called before the first frame update
        public void Start()
        {
            initialRotation_ = this.transform.localRotation;
            instance = this;
            
        }
        public void MoveToCenter()
        {
            this.transform.localPosition = desiredPosition;  //new Vector3(0.284f, 0.6807f, 0.345f);
            this.transform.localRotation = initialRotation_;
            GameStateManager.instance.BodyGrabFalse();
            GameStateManager.instance.HeadGrabTrue();
            Check = false;

        }
    }
}