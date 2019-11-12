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
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < 12)
        {
            transform.LookAt(player.transform);
            transform.position =
                Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        }
    }
}
