using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeHItCheck : MonoBehaviour
{
    private GameObject player;
    private float seenTimer = 0;
    public float timeToRespawn = 1f;

    public AudioSource enemySource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Something hit");
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Player Hit");
            

            


            RaycastHit hit;
            Vector3 direction = other.transform.position - this.transform.parent.position;
            direction = direction.normalized;
            //direction.y = 0f;

            if (Physics.Raycast(this.transform.parent.position, direction, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    seenTimer += Time.deltaTime;
                    if(enemySource != null && enemySource.isPlaying == false)
                    {
                        enemySource.Play();
                    }
                    
                    if(seenTimer >= timeToRespawn)
                    {
                        Respawn.instance.RespawnPlayer();
                        EventController.instance.OnPlayerSpotted();
                    }
                    Debug.Log("Player Hit by Raycast");
                    
                   
                }
                else
                {
                    seenTimer = 0f;
                }
            }
            else
            {
                seenTimer = 0f;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            seenTimer = 0f;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
