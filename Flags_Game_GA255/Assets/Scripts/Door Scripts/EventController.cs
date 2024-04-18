using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EventController : MonoBehaviour
{
    //Making this a singleton Class
    public static EventController instance;

    private void Awake()
    {
        instance = this;
    }


    /// <summary>
    /// Example of setting up an UnityAction
    /// Here we are creating a simple placeholder event called OnEnd
    /// To subscribe to this event from any of your script Use the syntax
    /// 
    /// * EventController.instance.OnEnd +=  * WHAT EVER YOUR FUNCTION NAME IS ON YOUR SCRIPT *
    /// 
    /// You can create multiple such events, Just make sure you call the correct function where you need it.
    /// In this example, You still have to call "EventController.instance.GameEnded()" somewhere for it to trigger.
    /// </summary>
    /// 

    public event Action FlagPickedUp;
    public void OnFlagPickedUp()
    {
        if(FlagPickedUp != null)
        {
            FlagPickedUp();
        }
    }

    public event Action FirstFlagReturned;
    public void OnFirstFlagReturned()
    {
        if (FirstFlagReturned != null)
        {
            FirstFlagReturned();
        }
    }

    public event Action SecondFlagReturned;
    public void OnSecondFlagReturned()
    {
        if (SecondFlagReturned != null)
        {
            SecondFlagReturned();
        }
    }

}
