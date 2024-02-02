using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Assets/New Item")]
public class Item : ScriptableObject
{
    public enum itemType
    {
        Primary,
        Secondary,
        Special,
        Helmet,
        Chestplate,
        Gloves,
        Leggings,
        Boots,
        Necklace
    };

    public itemType type;
}
