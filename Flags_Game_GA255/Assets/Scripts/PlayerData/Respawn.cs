using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 SpawnPosition;
    public static Respawn instance;
    public GameObject Flag1;
    public GameObject Flag2;
    public GameObject Flag3;
    private InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GetComponent<InventoryManager>();    
        instance = this;
        SpawnPosition = transform.position;
    }

    public void RespawnPlayer()
    {
        transform.position = SpawnPosition;
        if(Flag1 != null) //A null check will make sure we don't do anything with the object that will cause it to break if we destroy it!
        {
            Flag1.SetActive(true);
        }

        if (Flag2 != null)
        {
            Flag2.SetActive(true);
        }

        if(Flag3 != null)
        {
            Flag3.SetActive(true);
        }

        EventController.instance.OnFlagPickedUp();
        inventoryManager.RemoveFlag();
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
