using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class DoorRandomizer : MonoBehaviour
{
    public static DoorRandomizer instance;
    public List<DoorController> DoorSetOne = new List<DoorController>();
    public List<DoorController> DoorSetTwo = new List<DoorController>();
   // public int iterationCount;
        
   



    // Start is called before the first frame update
    void Start()
    {
        Invoke("Randomize", 1);
       // iterationCount = Mathf.Floor(DoorSetOne.Count /2);
    }

    private void Randomize()
    {
        int randomValue = Random.Range(0, DoorSetOne.Count);
        DoorSetOne[randomValue].ActivateDoor();

        GroupTwoRandomize();
    }

  
    public void GroupTwoRandomize()
    {
        List<DoorController> CopyOfGroupTwo = DoorSetTwo;

        for (int i= 0; i < 3; ++i) 
           
        {
            int Randomize = Random.Range(0, 3);
            CopyOfGroupTwo[Randomize].ActivateDoor();
            CopyOfGroupTwo.RemoveAt(Randomize);
        }
    }

   
   
    

    void Awake()
    {
        instance = this;

    }


}
