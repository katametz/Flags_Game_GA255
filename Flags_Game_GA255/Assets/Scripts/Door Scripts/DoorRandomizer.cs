using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoorRandomizer : MonoBehaviour
{
    public static DoorRandomizer instance;
    public List<DoorController> DoorSetOne = new List<DoorController>();
    public List<DoorController> DoorSetTwo = new List<DoorController>();


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Randomize", 1);

    }

    private void Randomize()
    {
        int randomValue = Random.Range(0, DoorSetOne.Count);
        DoorSetOne[randomValue].ActivateDoor();

        randomValue = Random.Range(0, DoorSetTwo.Count);
        DoorSetTwo[randomValue].ActivateDoor();
    }

    void Awake()
    {
        instance = this;

    }


}
