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

    enum EnemyStates
    {
        Patrolling,
        Chasing

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
    }

    void SetDestination()
    {
        if (currentState == EnemyStates.Chasing) _agent.SetDestination(objectToChase.position);
    }

//what happens when the mnster catches yhe pleyer
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {

            //Heres where health/death will go for monster
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
      