using UnityEngine;
using System;

public class ShootSoundManager : MonoBehaviour
{
    public AudioClip soundClip;  // the sound to play
    private AudioSource soundSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        soundSource = gameObject.AddComponent<AudioSource>();

        if (soundClip == null)
        {
            soundClip = Resources.Load<AudioClip>("laser"); // Assuming the audio file is placed in the Resources folder
        }

        if (soundClip != null)
        {
            soundSource.clip = soundClip;
            soundSource.loop = false;  //don't loop the sound, its a sound effect after all!
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            soundSource.Play();
        }

    }
}
