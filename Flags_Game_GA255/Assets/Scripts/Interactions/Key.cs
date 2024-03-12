using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player")) //Check if the player is the one that entered the trigger.
        {
            inventory.AddKey();//Add the key to the players inventory
            Destroy(this.gameObject); //make the key disappear
        }

        
        
    }
}
