using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

//https://www.youtube.com/watch?v=HGol5qhqjOE&ab_channel=FreedomCoding
//https://www.youtube.com/watch?v=Josw0x2geuQ&ab_channel=FreedomCoding

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]

public class ItemScriptableObject : ScriptableObject
{
    public itemType item_type;
    public Sprite item_sprite;
    public int id;
}

public enum itemType { test1, test2, test3}