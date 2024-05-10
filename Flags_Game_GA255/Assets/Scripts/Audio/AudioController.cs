using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource _source;
    public AudioClip DoorMovement;

    // Start is called before the first frame update
    void Start()
    {
        EventController.instance.FlagPickedUp += doorSound;

    }

    

    void doorSound()
    {
        _source.PlayOneShot(DoorMovement);
    }
}
