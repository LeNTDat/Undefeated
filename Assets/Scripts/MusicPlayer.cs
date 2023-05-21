using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    bool isPlaying = false;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
        {
            PlayMusic();
        }
    }

    void PlayMusic()
    {
        audioSource.Play();
        isPlaying = true;
    }
}
