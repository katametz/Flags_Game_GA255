using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour

{
    public int numFlag;

    public GameObject Flag1; 
    public GameObject Flag2;
    public GameObject Flag3;
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

    public void RemoveFlag()
    {
        numFlag--;
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

    public void CaptureFlag()
    {
        RemoveFlag();
        if(Flag1 != null && Flag1.activeSelf == false)
        {
            Destroy(Flag1);
        }

        if (Flag2 != null && Flag2.activeSelf == false)
        {
            Destroy(Flag2);
        }

        if (Flag3 != null && Flag3.activeSelf == false)
        {
            Destroy(Flag3);
        }
    }
}
