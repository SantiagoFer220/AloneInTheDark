using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//the tag of the thing picking up the object has to be "hand"
//also in the inspector u have to link "parentPlayer" to the hand 
///

public class PickupableItem : MonoBehaviour
{   // Start is called before the first frame update
    public bool touchedOrNot = false;

    public GameObject parentPlayer;
    //public GameObject childObject;
    public bool beingPickedUp = false;

    // public beingHeld=false;

    Rigidbody myRB;

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKey(KeyCode.Space) && other.CompareTag("hand"))
        {
            Debug.Log("touched");
            if (true)
            {
                myRB = this.GetComponent<Rigidbody>();
                // touchedOrNot = true;
                // Destroy(this.gameObject);
                this.transform.parent = parentPlayer.transform;
                //this.transform.position = parentPlayer.transform.position;
                // myRB.isKinematic = false;
                beingPickedUp = true;
                myRB.isKinematic = true;
            }


        }


    }
    void Start()
    {
        // this.transform.parent = parentPlayer.transform;
    }

    // Update is called once per frame
    void Update()
    {// this.transform.parent = parentPlayer.transform;
        if (beingPickedUp == true && Input.GetKey(KeyCode.B))
        {
            myRB = this.GetComponent<Rigidbody>();
            myRB.isKinematic = false;
            this.transform.parent = null;
            beingPickedUp = false;
            // 



        }

    }
}
