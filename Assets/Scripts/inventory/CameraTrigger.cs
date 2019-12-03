using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public Shot targetShot;


    private void OnTriggerEnter(Collider c)
    {
        if (c.CompareTag("Player"))
        {
            targetShot.CutToShot();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
