using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour

{
    public int numKeys; //This variable tracks the number of keys a player has.


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
        
    }
    public bool UseFlag()
    {
        if (numKeys > 0)
        {
            numKeys--;
            return true;
        }
        else
        {
            Debug.Log("You don't have a flag!");
            return false;
        }
    }
}
