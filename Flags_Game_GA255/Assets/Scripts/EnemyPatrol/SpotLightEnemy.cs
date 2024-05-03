using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpotLightEnemy : MonoBehaviour
{

    public Transform Player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()  
    {

        Vector3 dir = Player.transform.position - this.transform.position;

        Quaternion lookRot = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, speed * Time.deltaTime);


        //  this.transform.rotation
    }

        
}
