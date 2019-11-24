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
    public Item anohterItem;
    public bool InventoryIsActive;
    public bool isSelectingActions=false;




    // Start is called before the first frame update
    void Start()
    {
        myInventory = inventoryObject.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( !inventoryObject.activeSelf)//if inventory is NOT enabled
        {
            if (Input.GetKey(Forward)) {
                this.transform.Translate(0f, 0f, moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(Backward)) {
                this.transform.Translate(0f, 0f, -moveSpeed * Time.deltaTime);
            }

            if (Input.GetKey(RotateLeft)) {
                this.transform.Rotate(0f, -turnSpeed, 0f);
            }

            if (Input.GetKey(RotateRight)) {
                this.transform.Rotate(0f, turnSpeed, 0f);
            }
        }



        //////////////////INVENTORY CRAP
        ///
        //Add object
        if (Input.GetKeyDown(KeyCode.B)) {
            Debug.Log("space pressed to initiate interface");
            myInventory.AddItem(myItem);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("space pressed to initiate interface");
            myInventory.AddItem(anohterItem);
        }
        //delete object
        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("222space pressed to initiate interface");
           myInventory.RemoveItem(myItem);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("222space pressed to initiate interface");
            myInventory.RemoveItem(anohterItem);
        }

        //Close and Open Inventory window 
        if (Input.GetKeyDown(KeyCode.Space)) {
         //   if(inventoryObject.ac)
            inventoryObject.SetActive(!inventoryObject.activeSelf);

        }

        //selecting items
        if (inventoryObject.activeSelf && isSelectingActions==false) {
            if (Input.GetKeyDown(KeyCode.N))
            {
                myInventory.current++;
            }

        }

        //selecting actions on a certain item
        if (inventoryObject.activeSelf && isSelectingActions == true)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
            
                myInventory.currentAction++;
            }

        }

        if (inventoryObject.activeSelf && Input.GetKeyDown(KeyCode.A)) {
            isSelectingActions = !isSelectingActions;

        }
    }
}

