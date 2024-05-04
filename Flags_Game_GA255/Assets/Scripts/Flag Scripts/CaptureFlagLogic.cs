using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlagLogic : MonoBehaviour
{
    private InventoryManager inventoryManager;
    public int numFlagsCaptured = 0;
    public Light sceneLighting;
    public GameObject enemyGroup1;
    //public GameObject enemyGroup2;
    public GameObject player;
   

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GetComponent<InventoryManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("FlagReturn"))
        {
            if (inventoryManager.numFlag > 0)
            {
                numFlagsCaptured++;
                inventoryManager.CaptureFlag();
                Debug.Log("Flag Captured");
                

            }                 
                    if (numFlagsCaptured == 1)
                    {
                        enemyGroup1.SetActive(true);
                        sceneLighting.intensity = 1.5f;
                        player.GetComponent<Torch>().enabled = true;
                        Debug.Log("Darkening Scene");
                        Debug.Log("Enemies On");
                        EventController.instance.OnFirstFlagReturned();

                    }

                if (numFlagsCaptured == 2)
                {
                    //enemyGroup2.SetActive(true);
                    sceneLighting.intensity = .025f;
                    Debug.Log("Darkening Scene");
                    EventController.instance.OnSecondFlagReturned();
            }
            
                if (numFlagsCaptured == 3) 
                {
               
                       //win
                } 

        }

    }


}
