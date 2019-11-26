using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu]
public class Item : MonoBehaviour
{
    public bool beingInUse = false;

    public Text text;

    public Sprite sprite;
    public GameObject inventoryObject;
    public Inventory myInven;
    public bool touchedOrNot = false;
    //public Text text;
    public GameObject parentPlayer;

    public bool beingPickedUp = false;

    // public beingHeld=false;

    //Rigidbody myRB;


    //the following script pick up items
    //the input is to be modified. might need to access menu first
    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.P) && other.CompareTag("Player"))
        {
            Debug.Log("touched");
            if (true)
            {
                //   myRB = this.GetComponent<Rigidbody>();
                // touchedOrNot = true;
                // Destroy(this.gameObject);
                //  this.transform.parent = parentPlayer.transform;
                //this.transform.position = parentPlayer.transform.position;
                // myRB.isKinematic = false;
                beingPickedUp = true;
                myInven.AddItem(this);
                this.transform.position = new Vector3(999,999,999);
                //  myRB.isKinematic = true;

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
            //   myRB = this.GetComponent<Rigidbody>();
            //  myRB.isKinematic = false;
            //  this.transform.parent = null;
            beingPickedUp = false;
            // 



        }

    }



}
