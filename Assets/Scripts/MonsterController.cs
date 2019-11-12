﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float movespeed;

    private float maxdist = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(this.transform.position, this.transform.forward, Color.red, maxdist);

        if (Physics.Raycast(myRay, maxdist))
        {
            Debug.Log("hit!");
        }
        else
        {
            this.transform.Translate(0, 0, movespeed * Time.deltaTime);
        }
    }
}