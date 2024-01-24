using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Assets/New Item")]
public class Item : ScriptableObject
{
    public enum itemType
    {
        Kinetic,
        Special,
        Heavy,
        Helmet,
        Chestplate,
        Gloves,
        Leggings,
        Boots
    };

    public itemType type;


}
