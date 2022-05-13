using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
namespace Oculus.Interaction {
    public class GameStateManager : MonoBehaviour
    {
        public static GameStateManager instance;
        public GameObject[] Heads, Bodies, Lanterns;
        public Material[] mat;
        // Start is called before the first frame update
        void Start()
        {
            instance = this;
            foreach (GameObject go in Heads)
            {
                go.GetComponent<Transformable>().enabled = false;
                
            }

        }
        public bool HeadGrabTrue()
        {
            foreach (GameObject go in Heads)
            {
                go.GetComponent<Transformable>().enabled = true;
                go.GetComponent<InteractableUnityEventWrapper>().enabled = true;
            }
            return true;
        }
        public bool HeadGrabFalse()
        {
            foreach (GameObject go in Heads)
            {
                go.GetComponent<Transformable>().enabled = false;
                go.GetComponent<InteractableUnityEventWrapper>().enabled = false;
            }
            return false;
        }
        public bool BodyGrabFalse()
        {
            foreach (GameObject go in Bodies)
            {
                go.GetComponent<Transformable>().enabled = false;
                go.GetComponent<InteractableUnityEventWrapper>().enabled = false;
            }
            return false;
        }
        public bool BodyGrabTrue()
        {
            foreach (GameObject go in Bodies)
            {
                go.GetComponent<Transformable>().enabled = true;
                go.GetComponent<InteractableUnityEventWrapper>().enabled = true;
            }
            return true;
        }
        public void LanternLit(int i)
        {
            foreach(GameObject go in Lanterns)
            {
                Lanterns[i].transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        public void LanternTransparent(int i)
        {
            foreach (GameObject go in Lanterns)
            {
                Lanterns[i].GetComponent<MeshRenderer>().material.SetFloat("_Mode", 3);
                Lanterns[i].GetComponent<MeshRenderer>().material.SetInt("_SrcBlend", (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                Lanterns[i].GetComponent<MeshRenderer>().material.SetInt("_DstBlend", (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                Lanterns[i].GetComponent<MeshRenderer>().material.SetInt("_ZWrite", 0);
                Lanterns[i].GetComponent<MeshRenderer>().material.DisableKeyword("_ALPHATEST_ON");
                Lanterns[i].GetComponent<MeshRenderer>().material.EnableKeyword("_ALPHABLEND_ON");
                Lanterns[i].GetComponent<MeshRenderer>().material.DisableKeyword("_ALPHAPREMULTIPLY_ON");
                Lanterns[i].GetComponent<MeshRenderer>().material.renderQueue = 3000;
            }
        }
        // Update is called once per frame
        void Update()
        {

        }
    } 
}
