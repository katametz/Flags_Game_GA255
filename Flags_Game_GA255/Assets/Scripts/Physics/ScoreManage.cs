using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManage : MonoBehaviour
{
    private float totalScore = 0;
    public TextMeshProUGUI scoreText;


    public void AddScore(float score) //"void" = doesn't need to return antything, so it's just adding to 0
    {
        totalScore += score;

        scoreText.text = "Score: " + totalScore;

        Debug.Log("New Score = " + totalScore);
    }
}
