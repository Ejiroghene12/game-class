using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mash : MonoBehaviour
{


    void Start()
    {
        List<GameObject> itemsForRandomEnable = new List<GameObject>();
        foreach (Transform child in transform)
        {
            itemsForRandomEnable.Add(child.gameObject);
        }
        if (itemsForRandomEnable != null && itemsForRandomEnable.Count > 0)
        {
            int itemId = new System.Random().Next(itemsForRandomEnable.Count);
            for (int i = 0; i < itemsForRandomEnable.Count; i++)
            {
                if (i == itemId) { itemsForRandomEnable[i].gameObject.active = true; }
                else { itemsForRandomEnable[i].gameObject.active = false; }
            }
        }
    }
}
