using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ListSO<T> : ScriptableObject where T : class
{
    public List<T> itemsList;
    public int Count { get => itemsList.Count; }
}
