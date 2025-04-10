using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    public AudioClip soundClip;  // the sound to play
    private AudioSource musicSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        musicSource = gameObject.AddComponent<AudioSource>();

        if (soundClip == null)
        {
            soundClip = Resources.Load<AudioClip>("ChipTune"); // Assuming the audio file is placed in the Resources folder
        }

        if (soundClip != null)
        {
            musicSource.clip = soundClip;
            musicSource.loop = true;  //loop the sound, its background music after all!
        }

    }

    // Update is called once per frame
    void Update()
    {

        // check if the sound isn't already playing
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }

    }
}
