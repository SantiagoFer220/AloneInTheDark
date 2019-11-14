using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public Sprite sprite;

    public GameObject inventoryObject;
    public Inventory myInven;
    public bool touchedOrNot = false;
    public Text text;
    public GameObject parentPlayer;

    public bool beingPickedUp = false;

    // public beingHeld=false;
    public GameObject rigidbodyObject;

    Rigidbody myRB;


    //the following script pick up items
    //the input is to be modified. might need to access menu first
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.Space) && other.CompareTag("hand"))
        {
            Debug.Log("touched");
            if (true)
            {
                myRB = rigidbodyObject.GetComponent<Rigidbody>();
                // touchedOrNot = true;
                // Destroy(this.gameObject);
                rigidbodyObject.transform.parent = parentPlayer.transform;
                //this.transform.position = parentPlayer.transform.position;
                // myRB.isKinematic = false;
                beingPickedUp = true;
                myRB.isKinematic = true;

                //myInven.AddItem()
            }


        }


    }
    void Start()
    {
        // this.transform.parent = parentPlayer.transform;
        myInven = inventoryObject.GetComponent<Inventory>();
    }


    void Update()
    {// this.transform.parent = parentPlayer.transform;

        //the following thing DROP the item
        if (beingPickedUp == true && Input.GetKey(KeyCode.B))
        {
            myRB = rigidbodyObject.GetComponent<Rigidbody>();
            myRB.isKinematic = false;
            rigidbodyObject.transform.parent = null;
            beingPickedUp = false;
            // 



        }

    }

}
