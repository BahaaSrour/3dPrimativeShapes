using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ListSO<T> : ScriptableObject where T : NameClass
{
    public List<T> itemsList;
    public int Count { get => itemsList.Count; }

    public T GetItemByName(string name)
    {
        for (int i = 0; i < itemsList.Count; i++)
        {
            if (itemsList[i].name == name) return itemsList[i];
        }
        return null;
    }
}
