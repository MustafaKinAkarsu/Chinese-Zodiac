using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audios;
    public static AudioManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public AudioSource AudioPlay(int i)
    {
        AudioSource currentAudio = audios[i];
        currentAudio.Play();
        return currentAudio;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
