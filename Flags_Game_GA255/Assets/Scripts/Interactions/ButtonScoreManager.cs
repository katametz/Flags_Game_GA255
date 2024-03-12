using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScoreManager : MonoBehaviour
{
    public ButtonScoreManager scoreManager;
    public float scoreValue = 50;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GameObject.FindObjectOfType<ButtonScoreManager>();
    }

    public void AddScoreFromButton()
    {
       // scoreManager.AddScore(scoreValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
