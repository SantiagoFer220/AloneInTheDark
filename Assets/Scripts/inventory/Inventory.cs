using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject playerMovementObject;
    public PlayerMovement mypm;
    public int current = 0;
    public int currentAction = 0;
    public static int numOfCurrentSlot = 0;
    public const int numItemSlots = 5;
    public Image[] itemImages = new Image[numItemSlots];
    public Image[] BackgroundImages = new Image[numItemSlots];
    public Image[] itemBackgroundImages = new Image[numItemSlots];
    public Text[,] actionTexts = new Text[numItemSlots,2];
    public Item[] items = new Item[numItemSlots];
    public Text[] text = new Text[numItemSlots];
    //public Image select = new Image();

    public bool added = false;

    void Start() {
        mypm = playerMovementObject.GetComponent<PlayerMovement>();
    }

    void Update() {
        for (int i=0;i<items.Length;i++) {
            if (current >= numItemSlots) {
                current = 0;
            }
            if (currentAction >= numItemSlots)
            {
                currentAction = 0;
            }

            ///////////control selecting items background colors
            if (current == i && !mypm.isSelectingActions)
            {
                BackgroundImages[i].color = Color.blue;
                if (items[i] != null)
                {
                    itemImages[i].enabled = true;
                }

            }
            else {
                BackgroundImages[i].color = Color.black;
                itemImages[i].enabled = false;
            }


            ///////////control selecting actions background colors
            if (currentAction == i && mypm.isSelectingActions)
            {
                itemBackgroundImages[i].color = Color.blue;
                itemBackgroundImages[i].enabled = true;

        

            }
            else
            {
                itemBackgroundImages[i].color = Color.black;
                itemBackgroundImages[i].enabled = false;
         
            }


        }
    }
    public void AddItem(Item itemToAdd) {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {

                items[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
               // itemImages[i].enabled = true;
                text[i].text = "key or something";
                text[i].enabled = true;


                return;
            }
        }
        /*
        items[numOfCurrentSlot] = itemToAdd;
        itemImages[numOfCurrentSlot].sprite = itemToAdd.sprite;
        itemImages[numOfCurrentSlot].enabled = true;
        numOfCurrentSlot++;
        */

        /*
        for (int i = 0; i < items.Length; i++)
        {
            if (added == false)
            {
                if (items[i] == null && added==false)
                {
                    items[i] = itemToAdd;
                    itemImages[i].sprite = itemToAdd.sprite;
                    itemImages[i].enabled = true;
                    added = true;
                    itemToAdd = null;
                    itemToAdd.sprite = null;
                    return;


                }
            }
            added = false;
        }
     */
    }

    public void RemoveItem(Item itemToRemove) {

        for (int i = 0; i < items.Length; i++) {
            if (items[i] == itemToRemove) {
                items[i] = null;
                itemImages[i].sprite = null;
                itemImages[i].enabled = false;
                text[i].text = "";
                text[i].enabled = false;
                //  itemImages[i].enabled = false;
                return;


            }

        }

    }
}
