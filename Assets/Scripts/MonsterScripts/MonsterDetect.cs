using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDetect: MonoBehaviour
{
    public GameObject wall;
    public float maxdist = 100f;
   
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.FindWithTag("walls");
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(this.transform.position, this.transform.forward);
        Debug.DrawRay(this.transform.position, this.transform.forward, Color.magenta, maxdist);

        if (Physics.Raycast(myRay, maxdist))
        {
            Debug.Log("hit!");
            if (Physics.Raycast(myRay, maxdist))
            {
                float rand = Random.value;
                if (rand < 0.5f)
                {
                    this.transform.Rotate(0,-90f,0);
                }
                else
                {
                    this.transform.Rotate(0, 90f, 0);
                }

            }
            else
            {
                this.transform.Translate(0, 0, 0 * Time.deltaTime);
            }
        }

    }
}
