using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureFlagLogic : MonoBehaviour
{
    private InventoryManager inventoryManager;
    public int numFlagsCaptured = 0;
    public Light sceneLighting;
    public GameObject Enemies;
    public GameObject enemyGroup2;
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
            if(inventoryManager.numFlag > 0)
            {
                numFlagsCaptured++;
                inventoryManager.CaptureFlag();
                Debug.Log("Flag Captured");
                //This is where you will turn off the UI as well!

                
                    //numFlagsCaptured++;
                    if (numFlagsCaptured == 1)
                    {
                        Enemies.SetActive(true);
                        sceneLighting.intensity = 0.5f;
                        Debug.Log("Flag Captured, Darkening Scene");
                    }

                if (numFlagsCaptured == 2)
                {
                    enemyGroup2.SetActive(true);
                    sceneLighting.intensity = .025f;
                    player.GetComponent<Torch>().enabled = true;
                    Debug.Log("2 Flags Captured, Darkening Scene");
                }
            }

        }

        }


}
