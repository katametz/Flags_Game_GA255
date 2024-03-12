using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    public float TargetPoints;
    private ScoreManage scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        //scoreManager = GameObject.FindGameObjectWithTag("ScoreManaager").GetComponent<ScoreManager>();
        scoreManager = GameObject.FindObjectOfType<ScoreManage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collidingObject)
{
    if(collidingObject.gameObject.CompareTag("Projectile")) //check if colling object has the projectile tag
    {
        Debug.Log("Earned " + TargetPoints + " points!"); //display number of points for hitting the target

        scoreManager.AddScore(TargetPoints);

        Destroy(collidingObject.gameObject); //destroy cannonball upon collision
    }
}

}
