using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 SpawnPosition;
    public static Respawn instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SpawnPosition = transform.position;
    }

    public void RespawnPlayer()
    {
        transform.position = SpawnPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
