using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource _source;
    public AudioClip DoorMovement;
    public AudioClip FlagPickupSound;
    public AudioClip FlagDropoffSound;

    // Start is called before the first frame update
    void Start()
    {
        EventController.instance.FlagPickedUp += doorSound;
        EventController.instance.FirstFlagReturned += flagReturned;
        EventController.instance.SecondFlagReturned += flagReturned;

    }

    void flagReturned()
    {
        _source.PlayOneShot(FlagDropoffSound);
    }

    void doorSound()
    {
        _source.PlayOneShot(DoorMovement);
        _source.PlayOneShot(FlagPickupSound);
    }
}
