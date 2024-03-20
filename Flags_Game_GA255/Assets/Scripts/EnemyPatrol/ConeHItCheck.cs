using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeHItCheck : MonoBehaviour
{
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Respawn.instance.RespawnPlayer();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
