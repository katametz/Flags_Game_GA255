using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour
{
    private GameObject player;
    private InventoryManager inventory;
    public GameObject Teleporter;
   // public AudioSource audioSource;
    //public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<InventoryManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            //audioSource.Play();
            if(inventory.numFlag == 0)
            {
                inventory.AddFlag();
                EventController.instance.OnFlagPickedUp();

                if (Teleporter != null)
                {
                    Teleporter.SetActive(true);
                }

                this.gameObject.SetActive(false);
               
            }

        }
    }


}
        
    
    
        
    
    
       
    


