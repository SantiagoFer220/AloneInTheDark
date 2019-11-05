using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

public float moveSpeed;
public float turnSpeed;
public KeyCode Forward; 
public KeyCode Backward;
public KeyCode RotateRight;
public KeyCode RotateLeft;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(Forward)){
            this.transform.Translate(0f,0f,moveSpeed*Time.deltaTime);
        }

         if (Input.GetKey(Backward)){
            this.transform.Translate(0f,0f, -moveSpeed*Time.deltaTime);
        }

        if(Input.GetKey(RotateLeft)){
            this.transform.Rotate(0f,-turnSpeed,0f);
        }

        if(Input.GetKey(RotateRight)){
            this.transform.Rotate(0f,turnSpeed,0f);
        }

    }
}

