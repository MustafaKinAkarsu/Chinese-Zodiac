using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oculus.Interaction
{

    public class SnapPoint : MonoBehaviour
    {
        public static SnapPoint instance;
        public static bool isSnapped;


        // Start is called before the first frame update
        void Start()
        {
            isSnapped = false;
            instance = this;

        }

        private void OnTriggerEnter(Collider other)
        {
            var obj = (other.gameObject.tag);
            if (this.gameObject.tag == obj)
            {

                isSnapped = true;
                Debug.Log("Is trigger true");
            }
            else
            {
                isSnapped = false;
            }
        }
    }
}
