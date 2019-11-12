using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script deals with the different camera attributes we can change for every camera
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
