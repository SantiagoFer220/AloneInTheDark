using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static int numOfCurrentSlot = 0;
    public const int numItemSlots = 4;
    public Image[] itemImages = new Image[numItemSlots];
    public Item[] items = new Item[numItemSlots];
    public bool added = false;
    public void AddItem(Item itemToAdd) {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = itemToAdd;
                itemImages[i].sprite = itemToAdd.sprite;
                itemImages[i].enabled = true;
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
              //  itemImages[i].enabled = false;
                return;


            }

        }

    }
}
