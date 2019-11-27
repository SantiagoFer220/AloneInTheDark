using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script is attached to the different Camera position objects.\
//It sets the cameras future location and framing. It sets up the "Shots"
public class Shot: MonoBehaviour
{
    //sets the focal point of the camera
    public Vector3 focalPoint;
    public float FOV = 55f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this transforms the camera to the right position and focal point

    //this makes the camera move to the position of the shot taking its transform and rotation. 
    public void CutToShot()
    {
        transform.LookAt(focalPoint);
        Camera.main.transform.localPosition = transform.localPosition;
        Camera.main.transform.localRotation = transform.localRotation;

        Camera.main.fieldOfView = FOV; 
    }

    //switches cameras while in edit mode for easier setup
    void OnDrawGizmosSelected()
    {
        if (!Application.isPlaying)
        {
            CutToShot();
        }
    }

    //makes the lines that show where the cameras are pointing
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, focalPoint);

    }
}
