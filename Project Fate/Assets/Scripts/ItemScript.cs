using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public int itemLevel;

    public Item itemData;

    public void InitItem()
    {
        itemLevel = Random.Range(1, 50);
    }
}
