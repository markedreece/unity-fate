using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [Header("Equipped")]
    public GameObject equippedWeapon;
    public GameObject primary;
    public GameObject secondary;
    public GameObject special;


    [Header("Inventory")]
    public GameObject inventory;

    public void PickUp(GameObject g)
    {
        g.GetComponent<ItemScript>().InitItem();
        GameObject newItem;
        if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Primary)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(0)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Secondary)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(1)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Special)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(2)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Helmet)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(3)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Chestplate)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(4)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Gloves)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(5)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Leggings)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(6)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Boots)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(7)) as GameObject;
            newItem.SetActive(false);
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Necklace)
        {
            newItem = Instantiate(g, inventory.transform.GetChild(8)) as GameObject;
            newItem.SetActive(false);
        }
    }
}