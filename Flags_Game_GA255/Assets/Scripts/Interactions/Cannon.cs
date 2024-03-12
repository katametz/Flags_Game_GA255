using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall; //The cannonballprefab
    public Transform cannonBallSpawnLocation; // The location the cannonball should spawn
    public float cannonBallForce; //The force of the cannonball being shot
    public float rotationSpeed = 20f;
    public float cbForceAdjustment;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.eulerAngles -= new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.eulerAngles -= new Vector3(0f, 0f, 1f) * rotationSpeed * Time.deltaTime;
        }

            if (Input.GetKeyDown(KeyCode.Space)) //Check for player input
        {
            GameObject cb =Instantiate(cannonBall, cannonBallSpawnLocation.position, this.transform.rotation);

                cb.GetComponent<Rigidbody>().AddForce(this.transform.up * cannonBallForce); //get reference to the rigidbody on the cannon
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            cannonBallForce -= cbForceAdjustment;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            cannonBallForce += cbForceAdjustment;
        }
    }
}
