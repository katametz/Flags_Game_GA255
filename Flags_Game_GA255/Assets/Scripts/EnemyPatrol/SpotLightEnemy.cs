using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class SpotLightEnemy : MonoBehaviour
{

    public Transform Player;
    public float speed;

    public float minSpotlightDistance = 60f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()  
    {
        if (Vector3.Distance(Player.position, this.transform.position) < minSpotlightDistance)
        {
            this.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            this.transform.GetChild(0).GetComponent<ConeHItCheck>().enabled = false;

        }
        Vector3 dir = Player.transform.position - this.transform.position;

        Quaternion lookRot = Quaternion.LookRotation(dir);

        transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, speed * Time.deltaTime);


        //  this.transform.rotation
    }

        
}
