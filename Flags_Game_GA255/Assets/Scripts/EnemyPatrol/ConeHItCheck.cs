using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeHItCheck : MonoBehaviour
{
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            
            RaycastHit hit;
            Vector3 direction = other.transform.position - this.transform.position;
            direction = direction.normalized;
            direction.y = 0f;

            if (Physics.Raycast(this.transform.position, direction, out hit))
            {
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    Respawn.instance.RespawnPlayer();
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
