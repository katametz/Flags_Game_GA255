using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour

{
    public int numFlag; 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFlag()
    {
        numFlag++;
    }
    public bool UseFlag()
    {
        if (numFlag > 0)
        {
            numFlag--;
            return true;
        }
        else
        {
            Debug.Log("You don't have a flag!");
            return false;
        }
    }
}
