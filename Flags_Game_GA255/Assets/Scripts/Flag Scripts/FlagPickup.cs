using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickup : MonoBehaviour
{
    private GameObject player;
    private InventoryManager inventory;
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
            if(inventory.numFlag == 0)
            {
                inventory.AddFlag();
                this.gameObject.SetActive(false);
            }
            
        }
    }


}
        
    
    
        
    
    
       
    


