using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
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

    public void AddKey()
    {
        numKeys++;
    }
    public bool UseKey()
    {
        if(numKeys > 0)
        {
            numKeys--;
            return true;
        }
        else
        {
            Debug.Log("You don't have enough keys to open this door :(");
            return false;
        }
    }

}
