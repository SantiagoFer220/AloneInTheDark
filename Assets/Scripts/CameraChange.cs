using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public Camera[] cameras;
    public Collider[] triggers;
    public bool[] triggerBools;
    private int currentCameraIndex;

    
   // public Camera cameraone;
    //public Camera cameratwo;
    //public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       

      
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

    //check the trigger entered name, if the player enters 
    //the trigger x
    //then switch to camera x else if player enters trigger
    //y then change to camera y


    //Switching cameras
        for (int i = 0; i < triggerBools.Length; i++)
        {
            if (triggerBools[i] == true && other.gameObject.tag == ("pos" + i))
            {
                cameras[i].enabled = true;
            }
            else if (triggerBools[i] == false)
            {
                cameras[i].enabled = false;
            }

            }
    }
}

