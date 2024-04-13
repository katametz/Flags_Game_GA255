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
                //This is where you will turn off the UI as well!
            }
        }

        if(other.CompareTag("Player"))
        {
            numFlagsCaptured++;
        if (numFlagsCaptured == 1)
            {
                Enemies.SetActive(true);
                sceneLighting.intensity = 0.5f;
            }
        }

        else if(numFlagsCaptured == 2) 
        {
            enemyGroup2.SetActive(true);
            sceneLighting.intensity = .025f;
        }
    }
}
