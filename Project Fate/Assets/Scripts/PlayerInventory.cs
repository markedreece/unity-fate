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
    public GameObject helmet;
    public GameObject chestplate;
    public GameObject gloves;
    public GameObject legs;
    public GameObject boots;
    public GameObject necklace;

    [Header("Inventory")]
    public GameObject weaponHolder;
    public GameObject inventory;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Equip(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Equip(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Equip(3);
        }
    }

    private void Equip(int index)
    {
        if (inventory.transform.GetChild(index - 1).childCount == 0) { return; }
        
        if (index == 1)
        {
            if (equippedWeapon != null && equippedWeapon == primary) { return; }
            if (equippedWeapon != null && equippedWeapon != primary) { Destroy(weaponHolder.transform.GetChild(0).gameObject); }
            
            equippedWeapon = Instantiate(primary, weaponHolder.transform) as GameObject;

            equippedWeapon.SetActive(true);
        }
        else if (index == 2)
        {
            if (equippedWeapon != null && equippedWeapon == secondary) { return; }
            if (equippedWeapon != null && equippedWeapon != secondary) { Destroy(weaponHolder.transform.GetChild(0).gameObject); }

            equippedWeapon = Instantiate(secondary, weaponHolder.transform) as GameObject;

            equippedWeapon.SetActive(true);
        }
        else if (index == 3)
        {
            if (equippedWeapon != null && equippedWeapon == special) { return; }
            if (equippedWeapon != null && equippedWeapon != special) { Destroy(weaponHolder.transform.GetChild(0).gameObject); }

            equippedWeapon = Instantiate(necklace, weaponHolder.transform) as GameObject;

            equippedWeapon.SetActive(true);
        }
    }

    public void PickUp(GameObject g)
    {
        g.GetComponent<ItemScript>().InitItem();
        GameObject newItem;
        if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Primary)
        {
            if (primary == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(0)) as GameObject;
                newItem.SetActive(false);
                primary = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(0)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Secondary)
        {
            if (secondary == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(1)) as GameObject;
                newItem.SetActive(false);
                secondary = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(1)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Special)
        {
            if (special == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(2)) as GameObject;
                newItem.SetActive(false);
                special = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(2)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Helmet)
        {
            if (helmet == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(3)) as GameObject;
                newItem.SetActive(false);
                helmet = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(3)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Chestplate)
        {
            if (chestplate == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(4)) as GameObject;
                newItem.SetActive(false);
                chestplate = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(4)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Gloves)
        {
            if (gloves == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(5)) as GameObject;
                newItem.SetActive(false);
                gloves = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(5)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Leggings)
        {
            if (legs == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(6)) as GameObject;
                newItem.SetActive(false);
                legs = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(6)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Boots)
        {
            if (boots == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(7)) as GameObject;
                newItem.SetActive(false);
                boots = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(7)) as GameObject;
                newItem.SetActive(false);
            }
        }
        else if (g.GetComponent<ItemScript>().itemData.type == Item.itemType.Necklace)
        {
            if (necklace == null)
            {
                newItem = Instantiate(g, inventory.transform.GetChild(8)) as GameObject;
                newItem.SetActive(false);
                necklace = newItem;
            }
            else
            {
                newItem = Instantiate(g, inventory.transform.GetChild(8)) as GameObject;
                newItem.SetActive(false);
            }
        }
    }

    public void SlotEquip(GameObject equipped, int slot)
    {
        switch (equipped.GetComponent<ItemScript>().itemData.type)
        {
            case Item.itemType.Primary:

                break;
            default:
                Debug.Log("Error with SlotEquip...");
                break;
        }
    }
}