using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class DoorController : MonoBehaviour
{
    public Animator leftDoor;
    public Animator rightDoor;
    public bool doorState;
    public DoorType typeOfDoor;

    // Start is called before the first frame update
    void Start()
    {
        EventController.instance.FlagPickedUp += ActivateDoor;
        if(typeOfDoor== DoorType.groupOne) 
        {
            DoorRandomizer.instance.DoorSetOne.Add(this);
        }
        else if(typeOfDoor == DoorType.groupTwo) //can create multiple groups
        {
            DoorRandomizer.instance.DoorSetTwo.Add(this);
        } 
    }

    //if door group is greater than 3, randomize two doors. two unique values .........idk. sadge 
    public void ActivateDoor()
    {
        if (doorState == false)
        {
            leftDoor.Play("OpenDoor_01");
            rightDoor.Play("OpenDoor_02");
            doorState = true;
        }
        else
        {
            leftDoor.Play("ClosedDoor_01");
            rightDoor.Play("ClosedDoor_02");
            doorState = false;
        }

    }

}
public enum DoorType
{
    groupOne, //= 3 
    groupTwo, //= 6
}