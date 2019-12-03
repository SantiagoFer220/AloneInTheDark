using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{

    public GameObject player;
    public float dist;
    public float movespeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //player location, can be moved
        player = GameObject.Find("Player");
       // player.GetComponent<HealthSystem>().Damage(1);
    }

    // Update is called once per frame
    void Update()
    {
        // distance between the monster and the player
        dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < 100f)
        {
            // see the player, then use the given speed and position to move towards the player position on the maps
            transform.LookAt(player.transform);
            transform.position =
                Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        }

        void OnTriggerStay(Collider collision)
        {
            Debug.Log(collision.gameObject.tag);
            if (collision.gameObject.tag == "player")
            {
                player.GetComponent<HealthSystem>().Damage(1);

            }
        }
    }
}
