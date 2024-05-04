using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour


{
    public static AudioManager instance;

    public AudioSource audioSource;
    public AudioSource loudAudioSource;

    public AudioClip jingle1;
    public AudioClip jingle2;

    public AudioClip gunShot1;
    public AudioClip gunShot2;

    private void Start()
    {
        instance = this;
    }

    public void PlayGunShot1()
    {
        loudAudioSource.PlayOneShot(gunShot1);
    }

    public void PlayGunShot2()
    {
        loudAudioSource.PlayOneShot(gunShot2);
    }

    public void PlayJingle1()
    {
        loudAudioSource.PlayOneShot(jingle1, 0.5f); 
    }

    public void PlayJingle2()
    {
        loudAudioSource.PlayOneShot(jingle2);
    }
} 
  