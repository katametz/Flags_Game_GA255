using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyPathing : MonoBehaviour
{
    //public Transform patrolPath1;
    //public Transform patrolPath2;

    public List<Transform> patrolPaths;

    private int patrolPathIndex = 0;

    private NavMeshAgent navMeshAgent;

    private bool isChasingPlayer = false;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //navMeshAgent = this.GetComponent<NavMeshAgent>();
        //navMeshAgent.destination = patrolPath1.position;

        navMeshAgent = this.GetComponent<NavMeshAgent>();

        player = GameObject.FindGameObjectWithTag("Player");

        navMeshAgent.destination = patrolPaths[patrolPathIndex].position;

    }

    // Update is called once per frame
    void Update()
    {
       



        if (navMeshAgent.remainingDistance < 0.5f)
        {
            if (!isChasingPlayer)
            {
                patrolPathIndex++;

                if (patrolPathIndex >= patrolPaths.Count)
                {
                    patrolPathIndex = 0;
                }

                navMeshAgent.destination = patrolPaths[patrolPathIndex].position;
            }
            else if (isChasingPlayer)
            {
                if (Vector3.Distance(this.transform.position, player.transform.position) < 0.5f)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    isChasingPlayer = false;

                    navMeshAgent.destination = patrolPaths[patrolPathIndex].position;
                    
                }
            }

        }



    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something was hit!");

        if (other.CompareTag("Player"))
        {
            Debug.Log("The player was hit!");
            RaycastHit hit;
            Vector3 direction = player.transform.position - this.transform.position;
            direction = direction.normalized;

            if (Physics.Raycast(this.transform.position, direction, out hit))
            {
                Debug.Log(hit.collider.name);
                if (hit.collider.gameObject.CompareTag("Player"))
                {
                    Debug.Log("The player is in line of sight. Chase time!");
                    navMeshAgent.destination = hit.collider.transform.position;
                    isChasingPlayer = true;
                }
            }
        }
    }
}
