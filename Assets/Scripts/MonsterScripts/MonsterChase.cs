using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MonsterChase : MonoBehaviour
{
    private NavMeshAgent _agent;
    int _currentWaypoint = 0;
    [SerializeField] float decisionDelay = 2f;
    [SerializeField] Transform objectToChase;
    [SerializeField] Transform[] waypoints;

    [SerializeField] EnemyStates currentState;

    bool attacking = false;
    public Vector3 offset;



    enum EnemyStates
    {
        Patrolling,
        Chasing,
        StopChase,

    }

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        InvokeRepeating("SetDestination", 1.5f, decisionDelay);
        if (currentState == EnemyStates.Patrolling) _agent.SetDestination(waypoints[_currentWaypoint].position);
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, objectToChase.position) > 10f)
        {
            currentState = EnemyStates.Patrolling;
        }
        else
        {
            currentState = EnemyStates.Chasing;
        }


        if (currentState == EnemyStates.Patrolling)
        {
            if (Vector3.Distance(transform.position, waypoints[_currentWaypoint].position) < 0.6f)
            {
                _currentWaypoint++;
                if (_currentWaypoint == waypoints.Length)
                {
                    _currentWaypoint = 0;
                }
            }

            _agent.SetDestination(waypoints[_currentWaypoint].position);
        }

        if (attacking == true)
        {
            Debug.Log("Attack");
            currentState = EnemyStates.StopChase;
            
        }
        else if (Vector3.Distance(transform.position, waypoints[_currentWaypoint].position) < 0.6f)
        {
            currentState = EnemyStates.Patrolling;
        }
        else if (Vector3.Distance(transform.position, objectToChase.position) > 10f)
        {
            currentState = EnemyStates.Chasing;
        }

        if (currentState == EnemyStates.StopChase)
        {

            _agent.speed = 0;
            _agent.acceleration = 0;

        }
        else
        {
            _agent.speed = 1.5f;
            _agent.acceleration = 2f;
        }

    }



    void SetDestination()
    {
        if (currentState == EnemyStates.Chasing) _agent.SetDestination(objectToChase.position);
    }

    //what happens when the mnster catches yhe pleyer
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.name == "Player")
        {

            attacking = true;
            //Heres where health/death will go for monster
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

}

      