using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemActionScript : MonoBehaviour
{
    public GameObject doorObject;
    public OpenableDoor myDoor;
    // Start is called before the first frame update
    void Start()
    {
        myDoor = doorObject.GetComponent<OpenableDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseItem() {
        Debug.Log("Using the key!");
        myDoor.locked = false;
    }
}
