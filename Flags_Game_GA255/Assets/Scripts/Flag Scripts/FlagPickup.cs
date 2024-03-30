using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour
{
    private GameObject player;
    //private Inventory inventory;
    public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

            private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Add the flag to the player's inventory
            inventoryManager.AddFlagToInventory();

            // Destroy the flag GameObject
            Destroy(gameObject);
        }
    }


}
        
    
    
        
    
    
       
    


