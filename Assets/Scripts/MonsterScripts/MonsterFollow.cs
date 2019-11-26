﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterFollow : MonoBehaviour
{

    public GameObject player;
    public float dist;
    public float movespeed = 2.0f;
    public float maxdistfromplayer;

// Start is called before the first frame update
    void Start()
    {
        //player location, can be moved
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // distance between the monster and the player
        dist = Vector3.Distance(player.transform.position, transform.position);

        if (dist < maxdistfromplayer)
        {
            // see the player, then use the given speed and position to move towards the player position on the maps
            transform.LookAt(player.transform);
            transform.position =
                Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        }
    }
}
