using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDetect: MonoBehaviour
{
    public GameObject player;
    private float maxdist = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
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

    }
}
