using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour
{
    private GameObject player;
    private Inventory inventory;
    //public InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindObjectOfType<Inventory>();
    }

            private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            inventory.AddFlag();
            Destroy(this.gameObject); 
        }
    }


}
        
    
    
        
    
    
       
    


