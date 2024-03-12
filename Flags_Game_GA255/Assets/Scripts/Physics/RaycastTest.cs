using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //if player clicks left mouse button
        {
            RaycastHit hit; //have a variable to store what is hit by the raycast
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //get a ray from the camera to the mouse position
            if (Physics.Raycast(ray, out hit)) //out is a keyword "whatever output we want to put in this ray - checks if the ray hits an objec twith the collider.
            {
                Debug.Log(hit.collider.gameObject.name); //toss a debug log with the name of the object being hit
            }
        }
        
    }
}
