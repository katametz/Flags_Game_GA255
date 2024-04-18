using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon_Moving : MonoBehaviour
{
    public Animator triangleIcon;


    // Start is called before the first frame update
    void Start()
    {
        triangleIcon = GetComponent<Animator>();


        triangleIcon.Play("Icon_Top", -1, Random.Range(0f, 1f));

        triangleIcon.SetBool("Loop", true);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
