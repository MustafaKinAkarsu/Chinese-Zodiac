using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Oculus.Interaction
{
    public class HeadTransform : MonoBehaviour
    {
      //  public static HeadTransform instance;
        public Quaternion initialRotation_;
        public Vector3 initialPosition_;
        public Vector3 headPosition;
        public Vector3 lantLocation;
        private bool isReady;
        private static int i, l;
        private float desiredDuration = 1200f;
        private float elapsedTime;
        public int lanternIndex;
        GameObject Finding;
        static AudioSource thisAudio;
        private Vector3 objectPos;
        // private string objectTag;

        private void Start()
        {
            isReady = false;
            objectPos = new Vector3(-0.505988f, 1.665275f, -0.6508409f);
            #region BodAssign
           /* pigbod = new GameObject();
            oxbod = new GameObject();
            chickenbod = new GameObject();
            dragonbod = new GameObject();
            goatbod = new GameObject();
            horsebod = new GameObject();
            mousebod = new GameObject();
            monkeybod = new GameObject();
            rabbitbod = new GameObject();
            dogbod = new GameObject();
            snakebod = new GameObject();
            tigerbod = new GameObject();*/
           /* pigbod = (GameObject)game.Bodies.GetValue(0);
            oxbod = (GameObject)game.Bodies.GetValue(1);
            chickenbod = (GameObject)game.Bodies.GetValue(2);
            dragonbod = (GameObject)game.Bodies.GetValue(3);
            goatbod = (GameObject)game.Bodies.GetValue(4);
            horsebod = (GameObject)game.Bodies.GetValue(5);
            monkeybod = (GameObject)game.Bodies.GetValue(6);
            mousebod = (GameObject)game.Bodies.GetValue(7);
            rabbitbod = (GameObject)game.Bodies.GetValue(8);
            dogbod = (GameObject)game.Bodies.GetValue(9);
            snakebod = (GameObject)game.Bodies.GetValue(10);
            tigerbod = (GameObject)game.Bodies.GetValue(11);*/
            #endregion
        }
        private void Update()
        {
            MoveToLantern(); 
            if (thisAudio != null)
            {
                if (!thisAudio.isPlaying && MoveCenter.Check)
                {
                    GameStateManager.instance.BodyGrabTrue();
                }
            }
            



        }
        // Start is called before the first frame update
        public void MoveHead()
        {
            if (SnapPoint.isSnapped == true)
            {
                this.transform.localPosition = headPosition; //new Vector3(-2.8534f, 0.7664f, -11.2468f);
                this.transform.localRotation = initialRotation_;
                string Find_ = this.name;
                Find_ = Find_.Replace("Head", "Body");
                foreach(GameObject go in GameStateManager.instance.Bodies)
                {
                    if (go.name.Equals(Find_))
                    {
                        Finding = go;
                    
                    }
                }
                Debug.Log(lanternIndex);
                
                this.transform.parent = Finding.transform;
                isReady = true;
                GameStateManager.instance.LanternLit(lanternIndex);
                GameStateManager.instance.LanternTransparent(lanternIndex);                
                thisAudio = AudioManager.instance.AudioPlay(lanternIndex);
                GameStateManager.instance.HeadGrabFalse(); 
                GameStateManager.instance.BodyGrabFalse();
                MoveCenter.Check = true;
                SnapPoint.isSnapped = false;
                
            }
            else
            {
                transform.localPosition = initialPosition_;
                transform.localRotation = initialRotation_;
            }
            

        }
        public void MoveToLantern()
        {
            if (isReady)
            {
                elapsedTime += Time.deltaTime;
                float percentageCompleted = elapsedTime / desiredDuration;
                Finding.transform.localPosition = Vector3.Lerp((Finding.transform.position - objectPos), lantLocation, percentageCompleted);
            }
        }
    }
}
