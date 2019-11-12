using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is attached to the different Camera position objects. It sets the cameras future location and framing. It sets up the "Shots"
public class Shot: MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CutToShot()
    {
        Camera.main.transform.localPosition = transform.position;
        Camera.main.transform.localRotation = transform.rotation;
    }
}
