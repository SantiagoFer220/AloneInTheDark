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


    // //////////INVENTORY CRAP
    public GameObject inventoryObject;
    public Inventory myInventory;
    public Item myItem;




    // Start is called before the first frame update
    void Start()
    {
        myInventory = inventoryObject.GetComponent<Inventory>();
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



        //////////////////INVENTORY CRAP
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("space pressed to initiate interface");
            myInventory.AddItem(myItem);
        }
        if (Input.GetKey(KeyCode.B))
        {
            Debug.Log("space pressed to initiate interface");
            myInventory.RemoveItem(myItem);
        }

    }
}

