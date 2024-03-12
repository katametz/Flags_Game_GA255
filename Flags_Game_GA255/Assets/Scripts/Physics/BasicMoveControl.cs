using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoveControl : MonoBehaviour
{
    public Transform cubeTeleportPosition;
    public Vector3 rotVector;
    public Vector3 scaleVector;

    public float movementSpeed;
    public float rotationSpeed;
    public float movementRange;

    private bool moveRight = true; //Shree helped introduce and explain what private vs public means, and what the bool function does!
    public bool PlayerControl = false;


    // Start is called before the first frame update
    void Start()
    {

        //this.gameObject.SetActive(false);
        //this.transform.position = new Vector3(1f, 0f, 0f);
        this.transform.position = cubeTeleportPosition.position;
        this.transform.eulerAngles = rotVector;
        this.transform.localScale = scaleVector;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = cubeTeleportPosition.position;
        //this.transform.eulerAngles = rotVector;
        //this.transform.localScale = scaleVector;

        //this.transform.position = new Vector3(Mathf.PingPong(Time.deltaTime * 3f, 8), this.transform.position.y, this.transform.position.z);

        if (PlayerControl == true)
        {



            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += Vector3.left * movementSpeed * Time.deltaTime; //or new Vector3(1f, 0f, 0f); !

            }

            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += Vector3.right * movementSpeed * Time.deltaTime;

            }

            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += Vector3.up * movementSpeed * Time.deltaTime;

            }

            if (Input.GetKey(KeyCode.S))
            {
                this.transform.position += Vector3.down * movementSpeed * Time.deltaTime;

            }
        }
        else
        {
            if (moveRight)
            {
                this.transform.position += Vector3.right * movementSpeed * Time.deltaTime;
                if (this.transform.position.x >= movementRange)
                {
                    moveRight = false;
                }
            }
            else
            {
                this.transform.position += Vector3.left * movementSpeed * Time.deltaTime;
                if (this.transform.position.x <= -movementRange)
                {
                    moveRight = true;
                }
                
            }
        }
        this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        //I figured out all scripting myself, besides the player controller - Shree was kind enough to introduce and help me set up
        //the PlayerController, which basically is a toggle for turning the automatic L/R movement vs WASD movement I scripted on and off!
       
    }

}
