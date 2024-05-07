using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour

{
    public int numFlag;

    public GameObject Flag1; 
    public GameObject Flag2;
    public GameObject Flag3;

    public CanvasGroup returnFlagSprite;    //We need reference to a CanvasGroup I've added on the sprite that appears and fades out because that allows us to control the alpha value of that
                                            //object and any child objects. In this case, we're using it for a single object though, but if you wanted to add more to this sprite that fades
                                            //in the same way, you can add things as child objects of the ReturnFlag GameObject in the scene and it would work already with this script.

    public float returnFlagLiveTime = 2.5f; //This is the time that the returnFlagSprite will be fully visible before it starts to fade away.
    public float returnFlagFadeTime = 2.5f; //This is the time that it will take the returnFlagSprite to fade out from fully opaque to fully transparent.

    // Start is called before the first frame update
    void Start()
    {
        returnFlagSprite.alpha = 0f;    //When the game starts, it sets the alpha of the sprite's CanvasGroup to 0 (alpha goes from a scale of 0 to 1, where 0 is fully transparent
    }                                   //and 1 is fully opaque). We do this here so that it doesn't appear even though it's active and able to be seen in the inspector. This
                                        //makes it easier to move it around in the inspector if needed without being visible when it starts.

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFlag()
    {
        numFlag++;
        ReturnFlagSpriteSequence();     //We call the function here for the Return Flag Sprite Sequence because AddFlag is only called when a flag is picked up, perfect for when we want to show this.
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

    private void ReturnFlagSpriteSequence()     //This is the Function that is called that handles the whole sequence of the Return Flag sprite.
    {
        returnFlagSprite.DOKill();      //This is part of the DOTween package we downloaded. If we have reference to an object and call the DOKill() function on it. it will stop any
                                        //current tweens on this object so that a new one can be used without conflicting with each other.

        returnFlagSprite.alpha = 1f;    //Here, we immediately set the returnFlagSprite CanvasGroup's alpha variable to 1f. This means it will instantly become fully opaque.

        Sequence sequence = DOTween.Sequence();     //Next, we need to create a Sequence variable used by DOTween so that we can put the tween on a timeline, since we want it
                                                    //to start after so many seconds.

        sequence.Insert(returnFlagLiveTime, returnFlagSprite.DOFade(0f, returnFlagFadeTime));       //By using the sequence's .Insert() function, we can pass 2 variables to it.
                                                                                                    //The first variable is a float that determines how long after we start this sequence do
                                                                                                    //we want to call a tween. The second thing passed to the function is the Tween itself 
                                                                                                    //we want to run. In this case, we run the returnFlagSprite's DOFade() function, and pass
                                                                                                    //2 variables to it. The first is where we want the end result of the fade to land for the
                                                                                                    //returnFlagSprite's alpha variable. The second variable passed to the DOFade() function is
                                                                                                    //the time it will take to finish fading out.

        sequence.Play();    //Once all of the commands we need the tween to do have been written (just our single line at line 85), we need to tell the sequence to play. This will start
                            //the sequence and run all of the commands we've told it to do, which in this case, is to run returnFlagSprite.DOFade() after the time set by the returnFlagLiveTime
                            //float variable. After that time, it will fade out of the time determined by the returnFlagFadeTime float variable.
    }
}
