using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public GameObject equippedWeapon;

    public GameObject kinetic;
    public GameObject special;
    public GameObject heavy;
    public GameObject helmet;
    public GameObject chestplate;
    public GameObject gloves;
    public GameObject leggings;
    public GameObject boots;

    public GameObject[] kineticInventory = new GameObject[9];
    public GameObject[] specialInventory = new GameObject[9];
    public GameObject[] heavyInventory = new GameObject[9];
    public GameObject[] helmetInventory = new GameObject[9];
    public GameObject[] chestplateInventory = new GameObject[9];
    public GameObject[] glovesInventory = new GameObject[9];
    public GameObject[] leggingsInventory = new GameObject[9];
    public GameObject[] bootsInventory = new GameObject[9];

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && kinetic != null)
        {
            Equip(kinetic);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && special != null)
        {
            Equip(special);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && heavy != null)
        {
            Equip(heavy);
        }
    }

    public void Equip(GameObject item)
    {
        if(equippedWeapon == item) { return; }
        equippedWeapon = item;
        Instantiate(item);
    }

    public void PickUp(GameObject item)
    {
        if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Kinetic)
        {
            if(kinetic == null) { kinetic = item; return; }
            else
            {
                for(int i = 0; i < kineticInventory.Length; i++)
                {
                    if(kineticInventory[i] == null)
                    {
                        kineticInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Special)
        {
            if (special == null) { special = item; return; }
            else
            {
                for (int i = 0; i < specialInventory.Length; i++)
                {
                    if (specialInventory[i] == null)
                    {
                        specialInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Heavy)
        {
            if (heavy == null) { heavy = item; return; }
            else
            {
                for (int i = 0; i < heavyInventory.Length; i++)
                {
                    if (heavyInventory[i] == null)
                    {
                        heavyInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Helmet)
        {
            if (helmet == null) { helmet = item; return; }
            else
            {
                for (int i = 0; i < helmetInventory.Length; i++)
                {
                    if (helmetInventory[i] == null)
                    {
                        helmetInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Chestplate)
        {
            if (chestplate == null) { chestplate = item; return; }
            else
            {
                for (int i = 0; i < chestplateInventory.Length; i++)
                {
                    if (chestplateInventory[i] == null)
                    {
                        chestplateInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Gloves)
        {
            if (gloves == null) { gloves = item; return; }
            else
            {
                for (int i = 0; i < glovesInventory.Length; i++)
                {
                    if (glovesInventory[i] == null)
                    {
                        glovesInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Leggings)
        {
            if (leggings == null) { leggings = item; return; }
            else
            {
                for (int i = 0; i < leggingsInventory.Length; i++)
                {
                    if (leggingsInventory[i] == null)
                    {
                        leggingsInventory[i] = item;
                        return;
                    }
                }
            }
        }
        else if (item.GetComponent<ItemScript>().itemData.type == Item.itemType.Boots)
        {
            if (boots == null) { boots = item; return; }
            else
            {
                for (int i = 0; i < bootsInventory.Length; i++)
                {
                    if (bootsInventory[i] == null)
                    {
                        bootsInventory[i] = item;
                        return;
                    }
                }
            }
        }
    }
}
