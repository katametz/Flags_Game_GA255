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
    private bool isDoorOpen = false;
   // public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
        
        
        if (typeOfDoor== DoorType.groupOne) 
        {

            DoorRandomizer.instance.DoorSetOne.Add(this);
        }
        else if(typeOfDoor == DoorType.groupRandom) //can create multiple groups
        {
            EventController.instance.FlagPickedUp += ActivateDoor;
            int randomValue = Random.Range(0, 2);
            if(randomValue == 0)
            {
                doorState = false;
                ActivateDoor();
            }
            else
            {
                doorState = true;
                ActivateDoor();
            }
            //DoorRandomizer.instance.DoorSetTwo.Add(this);
        }
        else if (typeOfDoor == DoorType.layoutTwoDoor)
        {
            EventController.instance.FirstFlagReturned += OpenDoor;
        }
        else if (typeOfDoor == DoorType.layoutThreeDoor)
        {
            EventController.instance.SecondFlagReturned += OpenDoor;
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

    public void OpenDoor()
    {
        if(doorState == false)
        {
            leftDoor.Play("OpenDoor_01");
            rightDoor.Play("OpenDoor_02");
            doorState = true;
            //audioSource.Play();
        }
    }

    public void CloseDoor()
    {
        if (doorState == true)
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
    groupRandom,

    layoutTwoDoor,
    layoutThreeDoor,

}