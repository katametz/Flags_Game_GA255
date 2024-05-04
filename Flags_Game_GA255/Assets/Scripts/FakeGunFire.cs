using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeGunFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AudioManager.instance.PlayGunShot1(); //We call on the audio manager to run a function that will play a sound.
        }
     
    }
}
