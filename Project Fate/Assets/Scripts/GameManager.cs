using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] allItems;

    private void Awake()
    {
        allItems = Resources.LoadAll<GameObject>("Items");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GameObject newItem = Instantiate(allItems[Random.Range(0, allItems.Length - 1)]) as GameObject;
            newItem.GetComponent<ItemScript>().InitItem();
            GameObject.Find("Player").GetComponent<PlayerInventory>().PickUp(newItem);
        }
    }
}
