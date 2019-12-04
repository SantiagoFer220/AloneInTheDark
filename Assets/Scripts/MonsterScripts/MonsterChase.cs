using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
 
public class MonsterChase : MonoBehaviour {
    NavMeshAgent agent;
    int currentWaypoint = 0;﻿
    [SerializeField] float decisionDelay = 2f;
    [SerializeField] Transform objectToChase;
    [SerializeField] Transform[] waypoints;﻿
    
    [SerializeField] EnemyStates currentState;
    enum EnemyStates {
        Patrolling,
        Chasing
        
    }
    
    void Start () {
        agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("SetDestination", 1.5f, decisionDelay);
        if(currentState == EnemyStates.Patrolling) agent.SetDestination(waypoints[currentWaypoint].position);﻿
    }

    void Update()
    {if(Vector3.Distance(transform.position, objectToChase.position) >10f)
        {
            currentState = EnemyStates.Patrolling;
        }
        else
        {
            currentState = EnemyStates.Chasing;
        }
        
        if(currentState == EnemyStates.Patrolling)
        {
            if(Vector3.Distance(transform.position, waypoints[currentWaypoint].position) < 0.6f)
            {
                currentWaypoint++;
                if (currentWaypoint == waypoints.Length)
                {
                    currentWaypoint = 0;
                }
            }
            agent.SetDestination(waypoints[currentWaypoint].position);
        }
    }
    void SetDestination() {
        if(currentState == EnemyStates.Chasing) agent.SetDestination(objectToChase.position);
    }
    
    //what happens when the mnster catches yhe pleyer
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {
            //Heres where health/death will go
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}﻿