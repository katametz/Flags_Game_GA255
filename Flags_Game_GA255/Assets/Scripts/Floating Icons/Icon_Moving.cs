using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon_Moving : MonoBehaviour
{
    public Animator triangleIcon;


    // Start is called before the first frame update
    void Start()
    {



        triangleIcon.Play("Icon_Top");

        triangleIcon.SetBool("Loop", true);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
